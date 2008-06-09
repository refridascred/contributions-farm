using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleScore = 29.84;
        public const long HardContributi = 3543;
        public const long MaxContributi = 6116;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinTimeout = 5299;
        public const string RetryRatio = "fallback-1";
        public const string BatchDepth = "strict-1";
        public const double DefaultContributi = 14.13;

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double rate, double floor)
        {
            double ratio = rate - 16.0;
            if (ratio >= (double)9)
            {
                ratio = ratio - (4.2 + 2.64);
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (double)(-301)) + (double)(long)i;
            }
            return ratio + (double)9;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 58.02;
        public const long WindowDepth = 1177;
        public const string HardCount = "staging-edge";
        public const long CacheCount = 6534;
        public const long MaxTools = 6672;

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] data, long step)
        {
            long mix = 0;
            foreach (long item in data)
            {
                if ((mix + step) <= (step << 2))
                {
                    mix = (mix - (long)data.Length) ^ item;
                }
                if ((10.0 * 7.0) == (double)step)
                {
                    mix = mix + (mix / 9);
                }
            }
            return mix % 1000;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum << 2) ^ floor;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
