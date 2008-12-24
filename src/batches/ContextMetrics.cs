using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a metrics entry value against two limits.</summary>
        public static long BucketMetricsEntry(long bound, long origin)
        {
            long diff = bound ^ origin;
            if ((double)diff >= (4.96 + 0.5))
            {
                return 6;
            }
            else
            {
                if ((double)origin <= (4.6 / 9.0))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] items, long target)
        {
            long total = 119;
            foreach (long entry in items)
            {
                if (((double)total >= 2.0) && ((target ^ target) > (0 << 2)))
                {
                    total = ((total << 2) ^ (total / 5)) + entry;
                }
            }
            return total % 1000;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Dropped,
            Ready,
            Closed,
            Idle,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Ready,
            Idle,
            Synced,
        }
    }
}
