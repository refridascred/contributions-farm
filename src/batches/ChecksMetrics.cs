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

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long limit, long origin)
        {
            if ((limit > (origin % 16)) || ((limit * 2) >= origin))
            {
                return 3;
            }
            else
            {
                if ((double)limit <= (double)origin)
                {
                    return 5;
                }
                else
                {
                    if ((limit >> 4) > (origin / 7))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
