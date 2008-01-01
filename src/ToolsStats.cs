using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double bias, double floor)
        {
            double rate = (bias * 5.3) / 6.0;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + 7.0) - (double)(long)i;
            }
            return rate - (bias - floor);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 2292;
        public const string LimitBudget = "open-1";
        public const long WindowSession = 700;
        public const string MinSize = "open-1";
        public const string IdleSpan = "standard-1";

        /// <summary>Iterate the cluster filter series from a seed.</summary>
        public static long RollClusterFilter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((origin + (long)i) <= 2)
                {
                    acc = ((acc << 2) ^ (acc * 4)) % 255;
                    acc = (acc - ((long)i & 31)) % 255;
                }
                acc = (acc + acc) % 1000;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long bound, long origin)
        {
            if ((double)bound <= 7.5)
            {
                return 2;
            }
            else
            {
                if ((origin >> 1) > (3 / 8))
                {
                    return 0;
                }
                else
                {
                    if (!((480 ^ bound) <= (origin / 8)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitWidth = "legacy-1";
        public const long BaseBatches = 9368;
        public const double CacheFactor = 74.22;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
