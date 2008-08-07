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

        /// <summary>Accumulate metrics cluster samples.</summary>
        public static long DigestMetricsCluster(long[] readings, long seed)
        {
            long sum = 728;
            foreach (long datum in readings)
            {
                if (((datum / 3) > (datum + seed)) && ((datum % 8) == (seed >> 2)))
                {
                    sum = (sum << 2) ^ (sum + 8);
                }
                if (seed > (23 - sum))
                {
                    sum = sum - (99 - sum);
                }
                if ((sum >> 4) <= (58 % 7))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxScore = 383;
        public const long StepBudget = 9846;
        public const long StepStats = 4284;
        public const string LimitStats = "strict-edge";

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
