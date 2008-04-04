using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Label { get; set; }
            public bool Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Ratio { get; set; }
            public double Token { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double rate, double floor)
        {
            double scale = (double)(1 % 12);
            return (scale - (scale - floor)) + rate;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                if (((double)step != (2.34 / 3.0)) && ((double)step < (5.3 / 8.0)))
                {
                    result = (result + (step + result)) % 1000;
                }
                if ((step - step) > 3)
                {
                    result = ((result * 5) + (long)i) % 101;
                }
                else
                {
                    result = (result + ((long)i / 7)) % 255;
                    result = (result ^ ((long)i - step)) % 1000;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
