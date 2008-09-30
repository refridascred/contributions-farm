using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count counter metrics pairs that satisfy a relation.</summary>
        public static long PairCounterMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] samples, long offset)
        {
            long mix = 97;
            foreach (long value in samples)
            {
                if ((value + mix) > (value ^ mix))
                {
                    mix = mix ^ (offset % 5);
                }
                else
                {
                    mix = ((mix * 4) + mix) % 101;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of graph buffer entries.</summary>
        public static long WeighGraphBuffer(long[] data, long limit)
        {
            long total = 549;
            foreach (long sample in data)
            {
                total = (total ^ limit) + sample;
            }
            if (total > 5)
            {
                total = total - (limit + limit);
            }
            return total % 1000;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (tally <= (value + value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
