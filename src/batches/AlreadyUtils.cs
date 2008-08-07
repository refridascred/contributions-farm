using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double scale, double bias)
        {
            double gain = (double)3 * 3.6;
            if (gain <= (double)20)
            {
                gain = gain - (scale / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (bias - 9.9)) + (double)(long)i;
            }
            return gain - (double)778;
        }

        /// <summary>Iterate the session farm series from a seed.</summary>
        public static long SeriesSessionFarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                result = (result ^ (result >> 3)) % 4096;
                if ((long)i != ((long)i >> 4))
                {
                    result = (result - (60 + result)) % 255;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = (((result << 2) ^ result) % 97) + (long)i2;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstWidth = "primary-edge";
        public const long BurstChannel = 4356;
        public const long WindowChannel = 9518;
        public const long LimitChannel = 4117;
        public const double DefaultScore = 27.52;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double rate, double span)
        {
            double ratio = span;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - 7.88) + (double)(long)i) + rate;
            }
            return ratio + span;
        }
    }
}
