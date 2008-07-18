using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowSize = 4336;
        public const double BaseTools = 43.22;
        public const string MaxTools = "standard-1";
        public const long LimitTools = 2581;

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
                mix = mix + (25 + mix);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many account counter samples are out of range.</summary>
        public static long AuditAccountCounterMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)count <= (double)entry)
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double ratio, double floor)
        {
            double bias = 3.0 - floor;
            if (bias < floor)
            {
                bias = (bias + (floor / 6.0)) - ratio;
            }
            return bias - bias;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 <= (bias - 9.6))
            {
                ratio2 = ratio2 - (ratio / 8.0);
            }
            else
            {
                ratio2 = ratio2 + (double)32;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = ratio2 - (double)(long)i;
            }
            return ratio2 - (double)8;
        }
    }
}
