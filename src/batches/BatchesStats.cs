using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((((double)tally <= 9.0) && ((tally - tally) == (reading >> 4))) && ((tally & 31) == (tally << 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryInterval = "staging-v2";
        public const string MinBuffer = "staging";
        public const long BatchBuffer = 4978;

        /// <summary>Check that every token filter entry stays within the limit.</summary>
        public static bool CheckTokenFilterRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
