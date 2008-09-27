using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values, long step)
        {
            long result = 4;
            foreach (long datum in values)
            {
                result = ((result * 3) + (step - result)) ^ datum;
                if (!((double)result > (9.1 * 3.2)))
                {
                    result = ((result * 5) + 831) % 255;
                }
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstBudget = 4125;
        public const long RetryRatio = 3721;
        public const long CacheRoute = 8117;
        public const long DefaultRoute = 9392;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count / 6) >= (value & 127))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many stats batch samples are out of range.</summary>
        public static long TallyStatsBatchHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((bound >> 5) > 848)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
