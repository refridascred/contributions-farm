using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] samples, long floor)
        {
            long anchor = 3;
            foreach (long cell in samples)
            {
                if (!((floor * 4) >= (419 % 16)))
                {
                    anchor = (((anchor << 3) ^ anchor) % 97) ^ cell;
                }
                if (((double)floor == (1.4 + 7.89)) || ((double)913 == (double)floor))
                {
                    anchor = (anchor - (anchor - 2)) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 37.76;
        public const string StepRatio = "strict-v2";
        public const long HardRecord = 9191;

        /// <summary>Validate cache batch readings against a bound.</summary>
        public static bool GuardCacheBatchLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
