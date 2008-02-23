using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Draft,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
            public bool Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Active,
            New,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 5758;
        public const long BurstMetric = 4810;
        public const long CacheMetric = 9191;
        public const double CacheBudget = 84.11;
        public const string BatchBudget = "primary-v2";

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] data)
        {
            long mix = 19;
            foreach (long reading in data)
            {
                if (!((mix + 3) >= (reading / 8)))
                {
                    mix = ((mix << 2) ^ (56 + reading)) % 65521;
                    mix = (mix << 2) ^ reading;
                }
                mix = (mix - (mix * 5)) % 97;
                if ((double)mix < 5.8)
                {
                    mix = ((mix << 3) ^ (reading << 2)) % 1000;
                }
                if (72 > (mix + 0))
                {
                    break;
                }
            }
            return mix % 65521;
        }
    }
}
