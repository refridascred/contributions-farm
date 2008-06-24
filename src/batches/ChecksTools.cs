using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine layout cluster values into a single score.</summary>
        public static long FoldLayoutCluster(long[] items, long target)
        {
            long mark = 0;
            foreach (long entry in items)
            {
                mark = (mark + (target - target)) % 255;
                if (entry >= ((-78) - target))
                {
                    mark = mark + (entry + 84);
                }
            }
            return mark % 1000;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double ratio, double floor)
        {
            double drift = (double)6 - (floor - floor);
            if (drift > (ratio - 0.9))
            {
                drift = drift - (ratio + drift);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + (floor - drift);
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Paused,
            Synced,
            Idle,
        }
    }
}
