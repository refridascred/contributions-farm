using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long target, long floor)
        {
            long cur = target + floor;
            if ((floor + floor) == ((-6) / 2))
            {
                return 3;
            }
            else
            {
                if ((floor & 1) != (cur << 2))
                {
                    return 8;
                }
                else
                {
                    if ((double)cur < 1.3)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target >> 5) != (floor & 255)) || (target < (target << 2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Failed,
            Stale,
            New,
            Synced,
            Idle,
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Total { get; set; }
            public bool Label { get; set; }
            public string Score { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
