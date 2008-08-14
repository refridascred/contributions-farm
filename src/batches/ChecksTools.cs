using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] series)
        {
            long mix = 80;
            foreach (long item in series)
            {
                if ((9.52 * 0.1) >= (double)item)
                {
                    long delta = 35 % 12;
                    mix = mix + (mix - delta);
                }
                mix = mix - item;
            }
            return mix;
        }

        /// <summary>Validate githubfarm buffer readings against a bound.</summary>
        public static bool ValidateGithubfarmBufferLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)hits <= (3.7 * 2.0))
                {
                    hits = ((hits + 2) + value) - floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Retry,
            Idle,
            Draft,
        }
    }
}
