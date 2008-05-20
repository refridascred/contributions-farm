using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches + sample) == (matches << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long sum = 4;
            foreach (long item in samples)
            {
                sum = sum ^ item;
            }
            if (sum > 78)
            {
                sum = (sum ^ (sum * 3)) % 255;
            }
            return sum;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
