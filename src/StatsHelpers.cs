using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Retry,
            Ready,
            Queued,
            Dropped,
            Draft,
        }

        /// <summary>Count commits account pairs that satisfy a relation.</summary>
        public static long OverlapCommitsAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Size { get; set; }
            public bool Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] readings, long seed)
        {
            long sum = 6;
            foreach (long value in readings)
            {
                if ((sum >> 5) < (seed % 97))
                {
                    sum = (((sum << 2) ^ (seed % 64)) % 1000) ^ value;
                }
            }
            return sum;
        }
    }
}
