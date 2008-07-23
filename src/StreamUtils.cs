using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
            public long Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every profile context entry stays within the limit.</summary>
        public static bool VerifyProfileContextLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                if ((double)result < (9.38 * 8.1))
                {
                    result = (result * 5) + (target - target);
                }
                result = (result * 2) + (long)i;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of support buffer entries.</summary>
        public static long TotalSupportBuffer(long[] items)
        {
            long anchor = 50;
            foreach (long cell in items)
            {
                anchor = (((anchor * 3) + (long)items.Length) % 97) + cell;
                if (2 <= (anchor / 2))
                {
                    break;
                }
            }
            if (anchor > 8)
            {
                anchor = (anchor - (anchor + anchor)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseScore = 9506;
        public const long IdleLevel = 3744;
        public const string StepEditor = "latest";
        public const long RetryEditor = 5655;
        public const long DefaultEditor = 1403;
    }
}
