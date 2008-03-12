using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] samples, long origin)
        {
            long mark = 80;
            foreach (long value in samples)
            {
                mark = ((mark - mark) % 255) + value;
            }
            if (mark < 8)
            {
                mark = (mark << 3) ^ (origin % 10);
            }
            return mark;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetrySpan = 5.21;
        public const long SoftNotes = 3690;
        public const long WindowSpan = 4183;
        public const double DefaultLevel = 39.91;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Stale,
            Pending,
            Active,
            Synced,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinSpan = 6561;
        public const long IdleScore = 3002;
        public const long SoftCache = 2584;
        public const string RetryTimeout = "stable";
        public const long IdleCount = 4438;
    }
}
