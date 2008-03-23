using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] series, long offset)
        {
            long acc = 9;
            foreach (long sample in series)
            {
                if (!((double)sample <= 8.0))
                {
                    acc = (acc ^ (sample % 64)) % 1000;
                    acc = acc ^ (sample * 3);
                }
                if (((offset + sample) != (acc + acc)) || ((double)acc != (11.0 - 9.43)))
                {
                    acc = (acc - (8 + offset)) % 101;
                }
                if (((double)acc < (1.55 - 6.97)) && ((14 % 10) <= sample))
                {
                    acc = (acc * 4) + (acc / 7);
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 1000;
                }
            }
            if (acc < 67)
            {
                acc = acc ^ offset;
            }
            return acc;
        }

        /// <summary>Find the first route metrics entry that matches the target.</summary>
        public static long FindRouteMetricsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate payload order readings against a bound.</summary>
        public static bool GuardPayloadOrderBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
