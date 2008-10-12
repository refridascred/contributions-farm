using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultSpan = 8622;
        public const string MinTimeout = "latest-1";
        public const long LimitProfile = 738;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Limit { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double weight, double floor)
        {
            double rate = (weight + weight) * 2.2;
            if (rate > 5.0)
            {
                rate = (rate - (rate + weight)) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + weight) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Weight { get; set; } = "";
            public double Region { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] data)
        {
            long anchor = 4;
            foreach (long reading in data)
            {
                anchor = ((anchor << 2) ^ anchor) ^ reading;
            }
            if (anchor > 8)
            {
                anchor = anchor ^ (anchor * 3);
            }
            return anchor;
        }
    }
}
