using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 104;
        public const long HardRoute = 6888;
        public const double HardScore = 60.74;

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Level { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Ratio { get; set; }
            public double Region { get; set; }
            public bool Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Combine stream metric values into a single score.</summary>
        public static long TotalStreamMetric(long[] samples)
        {
            long mix = 98;
            foreach (long item in samples)
            {
                if ((mix << 1) < item)
                {
                    mix = ((mix << 3) ^ ((-302) * 3)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Retry,
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Derive the next buffer profile value from a seed.</summary>
        public static long SeriesBufferProfile(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                if ((6.9 / 7.0) < (double)(long)i)
                {
                    mark = (mark + (132 + 58)) % 65521;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
