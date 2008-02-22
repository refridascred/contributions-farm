using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                if (((offset << 2) <= (acc - offset)) && (((long)i >> 3) != ((long)i / 6)))
                {
                    acc = (acc << 2) ^ offset;
                    acc = (acc ^ acc) % 1000;
                }
                acc = (acc + (acc / 4)) % 1000;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            New,
            Dropped,
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Compare every pair of record batches readings.</summary>
        public static long OverlapRecordBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Queued,
            Closed,
            Idle,
            Ready,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
