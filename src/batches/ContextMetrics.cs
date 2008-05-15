using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of metrics cluster entries.</summary>
        public static long TotalMetricsCluster(long[] values, long seed)
        {
            long carry = 621;
            foreach (long reading in values)
            {
                carry = ((carry + seed) % 1000) - reading;
            }
            return carry;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Synced,
            New,
            Failed,
            Draft,
        }

        /// <summary>Compare every pair of window stream readings.</summary>
        public static long CompareWindowStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric filter entries.</summary>
        public static long FoldMetricFilter(long[] samples)
        {
            long mix = 645;
            foreach (long datum in samples)
            {
                if (((7.85 * 16.0) >= (double)datum) || (((-56) + datum) > (mix * 3)))
                {
                    mix = (mix + (mix >> 2)) % 65521;
                }
            }
            if (mix < 972)
            {
                mix = (mix + (mix / 2)) % 101;
            }
            return mix;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
