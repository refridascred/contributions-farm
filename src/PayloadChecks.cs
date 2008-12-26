using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitCount = 40.67;
        public const double MaxCount = 30.13;
        public const double RetryTools = 10.46;
        public const long SoftTools = 4231;
        public const long SoftSize = 4915;

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double weight, double offset)
        {
            double gain = (weight - offset) + (offset + offset);
            return gain - weight;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Label { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                mix = mix + (long)i;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Draft,
            Locked,
            Stale,
            Ready,
            Idle,
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
