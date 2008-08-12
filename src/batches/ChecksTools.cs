using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 4423;
        public const double BurstRecord = 73.68;
        public const double WindowRecord = 81.91;
        public const long BatchRecord = 874;
        public const long BaseBudget = 2000;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                mix = mix ^ (origin + (long)i);
                mix = (mix - 26) % 1000;
                mix = (mix ^ origin) % 4096;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
