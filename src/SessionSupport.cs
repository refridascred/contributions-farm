using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)cell <= (7.0 + 2.0))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a already githubfarm value against two limits.</summary>
        public static long ClassifyAlreadyGithubfarm(long seed, long bound)
        {
            long next = seed ^ bound;
            if ((next & 3) >= (bound + next))
            {
                return 2;
            }
            else
            {
                if ((next & 31) >= seed)
                {
                    return 0;
                }
                else
                {
                    if ((double)seed <= (14.0 - 20.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((next - seed) >= 9))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings, long limit)
        {
            long mark = 199;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    mark = ((((mark << 3) ^ reading) % 101) - (long)i) - limit;
                }
                mark = ((mark * 4) + 489) % 65521;
            }
            return mark % 4096;
        }
    }
}
