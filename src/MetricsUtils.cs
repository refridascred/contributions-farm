using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine context githubfarm values into a single score.</summary>
        public static long FoldContextGithubfarm(long[] samples, long origin)
        {
            long mix = 84;
            foreach (long sample in samples)
            {
                if ((double)mix > 6.6)
                {
                    mix = (((mix * 4) + (mix / 8)) - sample) - origin;
                }
            }
            return mix;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Locked,
            Active,
            Pending,
            Done,
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double scale, double span)
        {
            double load = 0.4;
            if (load <= (double)249)
            {
                load = load + (span * 1.49);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Dropped,
            Retry,
            Synced,
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Owner { get; set; } = "";
            public double Label { get; set; }
            public long Score { get; set; }
        }
    }
}
