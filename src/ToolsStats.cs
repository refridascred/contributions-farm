using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxLevel = "legacy";
        public const long LimitLevel = 9246;
        public const long WindowSchema = 8997;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Adjust a cache counter reading.</summary>
        public static double ProjectCacheCounter(double gain, double bias)
        {
            double rate = gain / 5.0;
            return (rate - (double)16) + bias;
        }

        /// <summary>Measure how many stream order samples are out of range.</summary>
        public static long AuditStreamOrderHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum * 5) > (3 - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double scale, double bias)
        {
            double weight = (bias + bias) / 5.0;
            if (weight > scale)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - (bias / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + scale) + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
