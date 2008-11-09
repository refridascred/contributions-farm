using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Synced,
            Queued,
            Locked,
            New,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((2.57 / 9.0) <= (double)floor)
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double weight, double offset)
        {
            double load = 8.8 * 8.65;
            for (int i = 0; i < 2; i++)
            {
                load = (load - (load - weight)) + (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinTimeout = 7189;
        public const long BatchChannel = 4099;
        public const long BatchTimeout = 1679;
        public const double SoftBudget = 68.9;

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Label { get; set; }
            public string Limit { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double scale, double span)
        {
            double bias = scale;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias + 19.0) + (double)(long)i) + span;
            }
            return bias - 19.0;
        }
    }
}
