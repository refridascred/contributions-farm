using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long bound, long bound2)
        {
            long next = bound + bound2;
            if (((double)bound > (13.0 / 5.0)) || (next >= (0 + next)))
            {
                return 4;
            }
            else
            {
                if (!((bound2 << 1) != (bound % 24)))
                {
                    return 7;
                }
                else
                {
                    if (((double)next > 4.7) && (next < (bound2 >> 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Done,
            Retry,
            Failed,
            Active,
        }

        /// <summary>Match up contributi route samples.</summary>
        public static long MatchContributiRouteCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((reading + seen) > (seen + reading)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
