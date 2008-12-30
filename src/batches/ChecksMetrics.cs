using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitFactor = 42.48;
        public const double MinWidth = 98.15;
        public const long MaxDepth = 7942;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Done,
            Queued,
            Pending,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Synced,
            Locked,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            Stale,
            Closed,
            New,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] values, long seed)
        {
            long sum = 7;
            foreach (long item in values)
            {
                sum = ((sum * 4) + (seed / 3)) ^ item;
                if ((sum + 512) < seed)
                {
                    sum = ((sum * 2) + (sum + seed)) % 1000;
                }
            }
            if (sum < 238)
            {
                sum = (sum ^ (sum ^ seed)) % 4096;
            }
            return sum % 1000;
        }
    }
}
