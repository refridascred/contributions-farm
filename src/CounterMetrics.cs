using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] samples, long seed)
        {
            long carry = 26;
            foreach (long entry in samples)
            {
                if ((entry <= (115 + (long)samples.Length)) || ((double)entry <= (double)67))
                {
                    carry = ((carry ^ (carry >> 3)) % 4096) - seed;
                }
                else
                {
                    carry = carry ^ (3 * 2);
                }
            }
            return carry;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (tally < (reading << 3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of already metric readings.</summary>
        public static long OverlapAlreadyMetricCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
