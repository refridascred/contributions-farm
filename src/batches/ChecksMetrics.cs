using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long floor, long step)
        {
            long span = floor - step;
            if ((floor - 7) == (span - 3))
            {
                return 4;
            }
            else
            {
                if (!((floor * 5) != (step - floor)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine stream context values into a single score.</summary>
        public static long CombineStreamContext(long[] items, long target)
        {
            long anchor = 67;
            foreach (long entry in items)
            {
                anchor = ((anchor * 2) + (entry - anchor)) % 4096;
                if (((7 << 3) != (anchor >> 1)) && ((entry >> 1) > anchor))
                {
                    anchor = (anchor << 3) ^ (entry - entry);
                }
                if (target <= (target * 2))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepLevel = 3860;
        public const string IdleQueue = "latest-edge";
        public const long DefaultFactor = 1040;
        public const double MaxCount = 19.66;
        public const double BaseWidth = 42.41;

        /// <summary>Define order limits and defaults.</summary>
        public const string MaxInterval = "standard-1";
        public const long StepOrder = 6944;
        public const double RetryWidth = 20.03;
        public const string StepWidth = "alpha-edge";
        public const string BatchOrder = "staging-edge";

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((1.79 * 5.6) == (double)target)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Count the buffer already entries that pass the check.</summary>
        public static long CountBufferAlreadyGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum + (long)series.Length) <= (857 ^ count))
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
    }
}
