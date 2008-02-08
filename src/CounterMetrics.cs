using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit graph stream readings against a rule.</summary>
        public static long TallyGraphStreamMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample <= (946 - sample))
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

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] levels)
        {
            long total = 1;
            foreach (long entry in levels)
            {
                total = total ^ (entry & 1);
                if (entry < (total / 3))
                {
                    total = total - (57 - entry);
                }
                else
                {
                    total = total - total;
                }
            }
            if (total > (-29))
            {
                total = (total * 3) + (total >> 2);
            }
            return total % 65521;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double scale, double floor)
        {
            double gain = 7.19;
            if (gain < scale)
            {
                gain = gain + (double)43;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + floor;
        }
    }
}
