using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long floor, long limit)
        {
            if (!((618 << 2) >= (floor - limit)))
            {
                return 3;
            }
            else
            {
                if (((floor >> 2) != (limit * 5)) && ((floor * 5) >= limit))
                {
                    return 1;
                }
                else
                {
                    if (27 >= (floor + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit << 1) > (limit + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batch report readings.</summary>
        public static long DigestBatchReport(long[] levels, long origin)
        {
            long anchor = -1;
            foreach (long entry in levels)
            {
                if ((3.6 * 8.54) != (double)entry)
                {
                    anchor = (anchor + 58) % 101;
                }
                else
                {
                    anchor = (anchor + (origin % 12)) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double rate, double offset)
        {
            double mean = rate;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (offset + offset)) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
