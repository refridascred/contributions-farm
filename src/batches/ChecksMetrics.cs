using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 8767;
        public const long CacheBuffer = 6366;
        public const long DefaultBuffer = 3755;
        public const long RetryBuffer = 371;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Total { get; set; }
            public bool Region { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] data)
        {
            long acc = 225;
            foreach (long sample in data)
            {
                acc = ((acc ^ (acc ^ acc)) % 1000) - sample;
            }
            if (acc > 90)
            {
                acc = (acc - (acc - acc)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Active,
            Queued,
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] series, long limit)
        {
            long mark = 737;
            foreach (long value in series)
            {
                if ((limit << 2) >= (mark + 788))
                {
                    mark = ((mark << 2) ^ (value & 7)) % 1000;
                }
            }
            if (mark < 251)
            {
                mark = ((mark * 4) + (mark - limit)) % 255;
            }
            return mark;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
