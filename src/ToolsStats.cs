using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepChannel = "legacy-edge";
        public const long SoftChannel = 1444;
        public const double DefaultChannel = 46.79;
        public const string MinChannel = "fallback-1";

        /// <summary>Fold a list of payload token readings.</summary>
        public static long TotalPayloadToken(long[] samples, long step)
        {
            long state = 6;
            foreach (long value in samples)
            {
                state = (((state * 2) + (613 ^ state)) + value) - step;
            }
            return state;
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double weight, double offset)
        {
            double ratio = offset;
            if (ratio <= ratio)
            {
                ratio = ratio + (ratio * 8.4);
            }
            else
            {
                ratio = ratio + (offset * 1.11);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - weight) + (double)(long)i;
            }
            return ratio - (offset - offset);
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry > 727)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double rate, double span)
        {
            double drift = span;
            return (drift + drift) + rate;
        }
    }
}
