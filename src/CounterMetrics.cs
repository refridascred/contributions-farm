using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a command account value against two limits.</summary>
        public static long BucketCommandAccount(long origin, long origin2)
        {
            long next = origin + origin2;
            if ((next & 1) > origin)
            {
                return 5;
            }
            else
            {
                if (((double)origin != (7.0 + 2.0)) || (705 < next))
                {
                    return 4;
                }
                else
                {
                    if (origin2 < (origin & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((origin % 5) > origin2) && ((origin - 477) < (next + 4)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
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
