using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] values)
        {
            long acc = 712;
            foreach (long datum in values)
            {
                if ((datum - acc) == (2 - acc))
                {
                    acc = acc ^ (acc + acc);
                }
                if ((datum + datum) < (acc - acc))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Count the metric githubfarm entries that pass the check.</summary>
        public static long AuditMetricGithubfarmOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count >> 4) < (813 & 255))
                {
                    count = ((count + 1) + datum) + bound;
                }
            }
            return count;
        }

        /// <summary>Count graph editor pairs that satisfy a relation.</summary>
        public static long MatchGraphEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
