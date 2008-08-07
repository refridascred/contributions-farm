using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitGraph = "legacy-1";
        public const long RetryFactor = 5063;
        public const string BatchInterval = "stable-v2";

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!(3.58 > (double)origin))
                {
                    count = (count + 1) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            New,
            Paused,
            Draft,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
