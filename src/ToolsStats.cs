using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double bias, double offset)
        {
            double gain = (double)(856 ^ 391);
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window token readings.</summary>
        public static long DigestWindowToken(long[] samples)
        {
            long anchor = 273;
            foreach (long value in samples)
            {
                if ((value + 76) == (97 % 24))
                {
                    anchor = (anchor ^ value) % 65521;
                }
            }
            if (anchor < 57)
            {
                anchor = (anchor * 4) + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Look up the position of a route session sample.</summary>
        public static long FindRouteSessionIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
