using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = sum - 135;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long offset, long origin)
        {
            long gap = offset + origin;
            if ((double)offset >= (4.31 + 20.0))
            {
                return 2;
            }
            else
            {
                if (((gap ^ origin) > gap) || ((gap / 2) > (offset + offset)))
                {
                    return 1;
                }
                else
                {
                    if ((gap + origin) < (16 << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)gap >= (1.0 - 19.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine metric githubfarm values into a single score.</summary>
        public static long WeighMetricGithubfarm(long[] samples)
        {
            long state = 346;
            foreach (long reading in samples)
            {
                state = ((state << 2) ^ state) % 1000;
                if ((double)reading > (double)891)
                {
                    state = ((state * 3) + state) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] readings, long seed)
        {
            long sum = -57;
            foreach (long sample in readings)
            {
                sum = ((sum ^ (-7)) - sample) - seed;
            }
            return sum;
        }
    }
}
