using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long seed, long bound)
        {
            long next = seed + bound;
            if (((seed << 1) < bound) && ((seed & 127) != (427 * 2)))
            {
                return 2;
            }
            else
            {
                if (9 < (next << 1))
                {
                    return 4;
                }
                else
                {
                    if ((double)next < 7.0)
                    {
                        return 7;
                    }
                    else
                    {
                        if (next > (bound ^ seed))
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
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double ratio, double bias)
        {
            double ratio2 = 3.0;
            if (ratio2 < (ratio + ratio2))
            {
                ratio2 = (ratio2 - (ratio2 / 2.0)) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + (18.0 * 5.5)) + (double)(long)i;
            }
            return ratio2 + (ratio2 - ratio);
        }
    }
}
