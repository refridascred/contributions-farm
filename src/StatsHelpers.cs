using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Region { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Find the first queue graph entry that matches the target.</summary>
        public static long LookupQueueGraphIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double weight, double span)
        {
            double scale = span - span;
            return (scale - (7.0 * 3.74)) + weight;
        }

        /// <summary>Scale a layout session figure with a bias.</summary>
        public static double AdjustLayoutSession(double rate, double floor)
        {
            double scale = rate;
            if (scale < 8.09)
            {
                scale = scale + (rate - floor);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (floor - 3.8)) + (double)(long)i;
            }
            return scale + (scale / 3.0);
        }
    }
}
