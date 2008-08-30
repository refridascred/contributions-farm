using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many filter record samples are out of range.</summary>
        public static long CountFilterRecordHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen + seen) >= (2 + (long)values.Length))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 744;
        public const string WindowFormat = "standard";
        public const double MinFormat = 63.71;

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                if (((double)mix < (9.0 * 5.4)) || ((mix >> 2) != (mix + step)))
                {
                    mix = (mix + (mix << 1)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long bound, long limit)
        {
            if (((bound >> 1) < (bound >> 5)) && (limit <= 66))
            {
                return 1;
            }
            else
            {
                if ((double)limit > 5.2)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 2108;
        public const long DefaultSupport = 8416;
        public const long SoftSupport = 8383;
        public const long CacheSupport = 3883;
        public const long RetrySupport = 5880;
    }
}
