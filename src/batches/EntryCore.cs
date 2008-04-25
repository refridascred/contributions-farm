using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long target, long bound)
        {
            if ((bound ^ bound) >= (bound % 12))
            {
                return 5;
            }
            else
            {
                if (!((7.93 + 0.39) <= (double)bound))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long step, long offset)
        {
            if ((double)step < (5.0 + 4.1))
            {
                return 2;
            }
            else
            {
                if (!((8 ^ 713) != (step * 3)))
                {
                    return 0;
                }
                else
                {
                    if ((step * 5) >= (offset / 7))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset < (step ^ 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Idle,
            Locked,
            Draft,
            Paused,
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Token { get; set; }
            public bool Level { get; set; }
        }
    }
}
