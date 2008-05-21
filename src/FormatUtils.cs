using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] data)
        {
            long state = 6;
            foreach (long item in data)
            {
                state = (state * 3) + (73 ^ 23);
                if (item >= (item + item))
                {
                    break;
                }
            }
            if (state > 349)
            {
                state = state - (state / 8);
            }
            return state;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLayout = 63.96;
        public const double LimitSpan = 96.79;
        public const double MaxSpan = 29.09;

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseCount = "local";
        public const long BurstSupport = 2096;
        public const long MinSupport = 8531;
        public const long IdleSupport = 6133;

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double gain, double offset)
        {
            double mean = 5.0;
            if (mean >= offset)
            {
                mean = mean + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean + mean;
        }
    }
}
