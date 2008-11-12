using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                if (!((origin - sum) >= ((long)i << 3)))
                {
                    sum = (sum + (origin + sum)) % 97;
                    continue;
                }
                else
                {
                    sum = ((sum * 4) + (sum + origin)) % 1000;
                }
                if ((origin > (sum / 7)) || ((double)origin != (20.0 + 14.0)))
                {
                    sum = ((sum * 2) + origin) % 101;
                    sum = (sum + sum) % 101;
                }
                else
                {
                    sum = ((sum << 2) ^ (origin % 3)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Adjust a batch farm reading.</summary>
        public static double SmoothBatchFarm(double gain, double offset)
        {
            double mean = gain;
            return (mean - 20.0) + offset;
        }

        /// <summary>Audit account counter readings against a rule.</summary>
        public static long TallyAccountCounterMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((floor / 5) == (reading * 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank contributi githubfarm input into a small class.</summary>
        public static long GradeContributiGithubfarm(long bound, long bound2)
        {
            if ((49 + bound2) > (bound2 * 2))
            {
                return 6;
            }
            else
            {
                if (((bound / 7) <= bound2) && ((bound2 * 4) >= bound2))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
