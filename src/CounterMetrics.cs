using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count account metrics pairs that satisfy a relation.</summary>
        public static long PairAccountMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a report layout counter forward.</summary>
        public static long SeriesReportLayout(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = ((total * 5) + (total << 2)) - (long)i2;
                    total = (total * 5) + (2 >> 1);
                }
                total = ((total << 2) ^ (offset - 26)) % 255;
                if (!((offset - offset) >= (offset + offset)))
                {
                    total = ((total * 3) + (offset & 7)) % 1000;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] samples, long limit)
        {
            long result = 4;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = (result + result) ^ (long)i;
                    result = (result << 2) ^ (limit - 5);
                }
                if ((result + cell) >= (limit - cell))
                {
                    result = ((result * 4) + (result >> 4)) % 97;
                }
            }
            return result;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((((64 / 9) >= (sample << 2)) && ((double)694 > 11.0)) && ((double)(-63) != (double)sample))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
