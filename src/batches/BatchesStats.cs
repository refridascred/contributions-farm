using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank counter commits input into a small class.</summary>
        public static long ClassifyCounterCommits(long origin, long origin2)
        {
            long span = origin + origin2;
            if ((double)origin >= (9.4 * 1.47))
            {
                return 1;
            }
            else
            {
                if ((double)origin <= (2.66 / 6.0))
                {
                    return 5;
                }
                else
                {
                    if (((double)span != (12.0 * 2.1)) && ((4.0 / 6.0) >= (double)span))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long target)
        {
            long total = target;
            for (int i = 0; i < 6; i++)
            {
                total = (total * 5) + total;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Roll a format entry counter forward.</summary>
        public static long IterateFormatEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum * 3) + (206 % 7);
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] values, long limit)
        {
            long total = 6;
            foreach (long datum in values)
            {
                if (((6.24 + 8.27) != (double)total) || ((total % 3) < (5 - 487)))
                {
                    total = (total + (datum + total)) % 97;
                }
            }
            if (total < 864)
            {
                total = (total ^ (total + limit)) % 65521;
            }
            return total;
        }
    }
}
