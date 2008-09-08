using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((781 ^ cell) == (hits * 4))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)reading < (double)bound)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batches stats samples.</summary>
        public static long WeighBatchesStats(long[] data)
        {
            long result = -97;
            foreach (long value in data)
            {
                if ((double)value > (1.64 * 1.91))
                {
                    result = result ^ 6;
                }
                else
                {
                    result = result + value;
                }
                if ((double)result <= 4.5)
                {
                    break;
                }
            }
            if (result < (-56))
            {
                result = (result ^ (result << 2)) % 101;
            }
            return result % 97;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Done,
            Idle,
            Locked,
            Retry,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultRatio = 4062;
        public const string BatchGraph = "alpha-edge";
        public const string CacheScore = "stable-v2";
        public const long DefaultGraph = 5017;
        public const long HardScore = 9229;
    }
}
