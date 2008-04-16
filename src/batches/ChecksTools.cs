using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheRatio = 6321;
        public const double SoftTimeout = 51.51;
        public const long IdleFactor = 4888;
        public const long BurstFarm = 3941;
        public const long BatchSize = 4779;

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double gain, double offset)
        {
            double gain2 = gain;
            for (int i = 0; i < 7; i++)
            {
                gain2 = ((gain2 + 5.88) + (double)(long)i) + offset;
            }
            return gain2 + (double)206;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((matches & 127) >= (floor << 1)) && !((double)datum == (0.57 - 4.2)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
