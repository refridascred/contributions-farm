using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every session stream entry stays within the limit.</summary>
        public static bool CheckSessionStreamRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchDepth = 7080;
        public const string MaxBudget = "cached-v2";
        public const long MaxScore = 8014;
        public const long HardSupport = 6182;

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 3744;
        public const string WindowCount = "open-1";
        public const string DefaultTimeout = "local-1";

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long limit, long seed)
        {
            long step = limit ^ seed;
            if ((seed + step) >= (seed - seed))
            {
                return 8;
            }
            else
            {
                if (!((double)limit != (double)step))
                {
                    return 2;
                }
                else
                {
                    if ((limit ^ seed) > (step - limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
