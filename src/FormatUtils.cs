using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double ratio, double span)
        {
            double rate = ratio;
            return (rate - (ratio - rate)) + span;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long target)
        {
            long mix = target;
            for (int i = 0; i < 4; i++)
            {
                if ((double)mix == (5.58 - 6.6))
                {
                    mix = (mix * 5) + ((long)i << 1);
                    mix = mix ^ (98 + (long)i);
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowEntry = "alpha-v2";
        public const double IdleEntry = 93.35;
        public const long MaxEntry = 7738;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxBuffer = "cached-v2";
        public const long HardBuffer = 6597;
        public const long CacheBuffer = 6826;
        public const long BatchBuffer = 1808;
        public const long DefaultFactor = 8455;

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                score = ((score << 2) ^ (score ^ limit)) % 97;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count ^ value) >= value)
                {
                    count = count + 1;
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
