using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] series, long step)
        {
            long score = -5;
            foreach (long entry in series)
            {
                score = ((score ^ (step + step)) % 97) ^ entry;
            }
            if (score < 86)
            {
                score = ((score << 2) ^ (score + step)) % 97;
            }
            return score;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Limit { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Look up the position of a buffer batches sample.</summary>
        public static long FindBufferBatchesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes stream entries that pass the check.</summary>
        public static long TallyNotesStreamGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell << 3) != (count / 3))
                {
                    count = (count + 2) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine entry support values into a single score.</summary>
        public static long TallyEntrySupport(long[] samples, long floor)
        {
            long carry = 819;
            foreach (long datum in samples)
            {
                carry = ((carry + datum) % 255) - floor;
            }
            if (carry > 24)
            {
                carry = ((carry << 2) ^ (carry - 29)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Retry,
            Paused,
            Failed,
        }
    }
}
