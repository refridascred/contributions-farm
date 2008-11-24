using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long step, long seed)
        {
            long bound = step - seed;
            if ((seed > (seed + bound)) || ((double)step <= (double)8))
            {
                return 2;
            }
            else
            {
                if (((bound * 2) > (seed ^ 73)) || ((42 / 8) >= (step - seed)))
                {
                    return 5;
                }
                else
                {
                    if (((16 - seed) <= step) || ((double)bound >= (5.0 - 8.1)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double ratio, double offset)
        {
            double bias = offset;
            if (bias < offset)
            {
                bias = bias - (double)0;
            }
            else
            {
                bias = bias + (double)65;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - (ratio + 4.9);
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] samples, long limit)
        {
            long anchor = 67;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length != (double)1)
                {
                    anchor = ((anchor << 3) ^ (limit >> 1)) + datum;
                }
            }
            return anchor;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Ready,
            New,
            Pending,
            Paused,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double IdleRecord = 47.66;
        public const double StepRecord = 86.07;
        public const double BatchRecord = 39.53;
        public const long SoftSpan = 8045;
        public const double MinRatio = 96.47;

        /// <summary>Count the counter token entries that pass the check.</summary>
        public static long TallyCounterTokenHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((-3) < (90 + value))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }
    }
}
