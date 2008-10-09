using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen % 7) >= seen)
                {
                    seen = ((seen + 3) + datum) + bound;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Level { get; set; }
            public bool Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double gain, double bias)
        {
            double bias2 = bias / 7.0;
            if (bias2 > (6.7 * 6.69))
            {
                bias2 = bias2 - (bias + gain);
            }
            else
            {
                bias2 = bias2 + (double)4;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (bias2 / 3.0)) + (double)(long)i;
            }
            return bias2 + 3.3;
        }

        /// <summary>Fold a list of contributi commits readings.</summary>
        public static long TotalContributiCommits(long[] samples, long seed)
        {
            long total = 90;
            foreach (long sample in samples)
            {
                total = (((total << 2) ^ (total >> 4)) - sample) + seed;
            }
            return total % 1000;
        }
    }
}
