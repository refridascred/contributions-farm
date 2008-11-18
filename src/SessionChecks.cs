using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a context counter pair into a bucket.</summary>
        public static long GradeContextCounter(long floor, long target)
        {
            long gap = floor ^ target;
            if (target >= gap)
            {
                return 2;
            }
            else
            {
                if ((870 >> 5) == (target + gap))
                {
                    return 8;
                }
                else
                {
                    if ((gap * 4) >= gap)
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor >= (1 % 60))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream stats readings against a rule.</summary>
        public static long MeasureStreamStatsMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((tally / 5) <= tally) && (((tally - sample) > (446 ^ sample)) || ((double)sample >= (7.49 * 8.5))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double scale, double bias)
        {
            double weight = scale / 7.0;
            if (weight <= weight)
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (double)(-6)) + (double)(long)i;
            }
            return weight - (double)70;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
