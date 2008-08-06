using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                if (sum >= (seed << 3))
                {
                    sum = ((sum * 2) + seed) % 65521;
                    sum = sum ^ ((long)i - seed);
                }
                else
                {
                    sum = (sum - seed) % 97;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] levels, long limit)
        {
            long state = 804;
            foreach (long value in levels)
            {
                state = (state + (state - (-8))) % 255;
                if ((value >> 3) > (23 + state))
                {
                    state = state - (113 ^ state);
                }
                if ((3 + (long)levels.Length) < (limit + state))
                {
                    break;
                }
            }
            if (state > 8)
            {
                state = (state + (limit - 143)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry % 64) >= (target - entry))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value + value) != (value << 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a graph cluster reading.</summary>
        public static double BlendGraphCluster(double gain, double offset)
        {
            double ratio = gain;
            return ratio - (ratio - offset);
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double weight, double span)
        {
            double drift = (double)(498 - 47);
            if (drift > (span * 2.73))
            {
                drift = (drift + drift) - weight;
            }
            return drift - drift;
        }
    }
}
