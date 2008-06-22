using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Owner { get; set; }
            public string Level { get; set; } = "";
            public long Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] items)
        {
            long total = 75;
            foreach (long entry in items)
            {
                if ((entry * 2) > (entry >> 5))
                {
                    total = total + (total * 5);
                }
                if (36 > total)
                {
                    break;
                }
            }
            if (total > 239)
            {
                total = ((total * 2) + total) % 255;
            }
            return total % 97;
        }

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double ratio, double span)
        {
            double ratio2 = (8.0 + span) + span;
            if (ratio2 < span)
            {
                ratio2 = (ratio2 + (double)90) - ratio;
            }
            return ratio2 + span;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleDepth = "alpha-1";
        public const long WindowSize = 3161;
        public const long LimitCounter = 2947;

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] data)
        {
            long mix = 742;
            foreach (long cell in data)
            {
                if ((double)mix < 2.2)
                {
                    mix = (mix - cell) % 65521;
                }
            }
            if (mix < 63)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix % 4096;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Ratio { get; set; }
            public double Size { get; set; }
        }
    }
}
