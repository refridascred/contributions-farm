using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            New,
            Pending,
            Idle,
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a stats account counter forward.</summary>
        public static long StepStatsAccount(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((double)28 >= (double)origin)
                {
                    total = total - origin;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry > (matches - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
