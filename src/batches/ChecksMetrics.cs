using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            Retry,
            Synced,
            Failed,
            Stale,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!((sample * 5) <= origin))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                long diff = (7 + state) + ((long)i - (-54));
                if (diff > ((long)i - 9))
                {
                    diff = (diff - (offset << 2)) % 4096;
                    continue;
                }
                diff = diff - (offset & 15);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Rank metrics githubfarm input into a small class.</summary>
        public static long SortMetricsGithubfarm(long seed, long seed2)
        {
            long bound = seed ^ seed2;
            if ((seed2 + 7) == (seed * 3))
            {
                return 4;
            }
            else
            {
                if ((seed - seed2) >= ((-66) - bound))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed < 9.0)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed2 + bound) > (seed >> 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxSpan = 7606;
        public const double RetryScore = 63.5;
        public const string BaseMetrics = "legacy-v2";
        public const string MaxFactor = "stable-1";
        public const long LimitMetrics = 3179;

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }
    }
}
