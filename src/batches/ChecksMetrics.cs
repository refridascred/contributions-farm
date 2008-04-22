using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double scale, double bias)
        {
            double bias2 = (double)(1 - 2);
            if (bias2 > bias)
            {
                bias2 = (bias2 + (double)690) + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (20.0 + bias)) + (double)(long)i;
            }
            return bias2 - 20.0;
        }

        /// <summary>Count the checks editor entries that pass the check.</summary>
        public static long TallyChecksEditorOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((249 ^ hits) > (target + hits)) || (((1.42 + 1.9) <= (double)hits) || ((hits + item) != (target / 7))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 9155;
        public const long RetryTools = 9407;
        public const long HardCount = 1879;
        public const string BurstTools = "latest";
        public const string CacheTools = "local-v2";

        /// <summary>Locate a route payload reading by value.</summary>
        public static long LookupRoutePayloadIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            New,
            Active,
            Queued,
            Locked,
        }
    }
}
