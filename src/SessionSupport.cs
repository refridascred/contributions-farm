using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double gain, double span)
        {
            double load = span;
            if (load > (span + load))
            {
                load = load + (gain - load);
            }
            else
            {
                load = load - (gain * 10.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load + (double)(-600);
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (8.88 > (double)seen)
                {
                    seen = ((seen + 1) ^ value) + target;
                }
            }
            return seen;
        }
    }
}
