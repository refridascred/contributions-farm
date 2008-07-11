using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Queued,
            Paused,
            Stale,
            Done,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] readings)
        {
            long state = -9;
            foreach (long cell in readings)
            {
                state = (state + cell) % 255;
                if ((cell ^ cell) > (cell * 2))
                {
                    state = state + (cell & 31);
                }
                else
                {
                    state = (state + (state >> 4)) % 4096;
                }
                if ((13 - cell) < cell)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            Active,
            Pending,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long origin, long floor)
        {
            long diff = origin - floor;
            if ((floor * 3) < (364 % 5))
            {
                return 4;
            }
            else
            {
                if (floor < (floor >> 1))
                {
                    return 6;
                }
                else
                {
                    if (origin <= (origin + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((diff >> 4) >= (floor + origin)) && (origin < (floor - diff)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double rate, double floor)
        {
            double weight = (rate + rate) + (double)594;
            if (weight < floor)
            {
                weight = weight + (6.9 / 3.0);
            }
            else
            {
                weight = weight - (double)744;
            }
            return weight + (floor + weight);
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample >> 1) != (matches - sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
