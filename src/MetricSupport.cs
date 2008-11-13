using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                if (mix >= 3)
                {
                    mix = mix + (origin << 1);
                }
                if ((9 & 7) >= (mix - (long)i))
                {
                    mix = mix + (mix + mix);
                    mix = (mix << 2) ^ origin;
                }
                else
                {
                    mix = (mix + (mix >> 3)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit counter githubfarm readings against a rule.</summary>
        public static long AuditCounterGithubfarmOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (152 >= (cell % 10))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((offset & 255) > (item * 5))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
