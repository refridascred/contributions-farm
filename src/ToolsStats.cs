using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double scale, double bias)
        {
            double load = 6.87;
            if (load < bias)
            {
                load = load + (bias * 4.94);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (bias + bias)) + (double)(long)i;
            }
            return load - (scale / 8.0);
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell < 8.5)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultBudget = 1142;
        public const long BurstSpan = 9333;
        public const long BaseTimeout = 1709;
        public const string BurstStream = "staging-v2";
        public const long DefaultStream = 1211;

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long floor)
        {
            long state = floor;
            for (int i = 0; i < 22; i++)
            {
                if (!((double)floor != (double)(long)i))
                {
                    state = state ^ floor;
                    state = state + (floor << 3);
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long target)
        {
            long mix = target;
            for (int i = 0; i < 20; i++)
            {
                if (((double)target < 1.65) || (7.61 >= (double)target))
                {
                    mix = (mix + (mix << 1)) % 4096;
                }
                mix = (mix ^ (target ^ (long)i)) % 1000;
                mix = ((mix * 5) + (target * 4)) % 4096;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double ratio, double floor)
        {
            double bias = (double)(926 - 884);
            if (bias <= bias)
            {
                bias = (bias - (bias / 9.0)) + floor;
            }
            else
            {
                bias = bias - (bias + ratio);
            }
            return bias - 5.03;
        }
    }
}
