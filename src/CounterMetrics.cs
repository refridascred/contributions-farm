using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] levels, long target)
        {
            long sum = 445;
            foreach (long cell in levels)
            {
                sum = (sum - (cell - cell)) % 1000;
                sum = sum - (target ^ sum);
                sum = ((sum << 3) ^ (cell + cell)) % 1000;
                if ((target - sum) > (sum + target))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits > (hits - item))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }
    }
}
