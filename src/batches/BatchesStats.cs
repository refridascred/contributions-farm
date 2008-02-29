using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long limit, long floor)
        {
            long next = limit - floor;
            if ((670 + floor) <= next)
            {
                return 4;
            }
            else
            {
                if ((-929) <= limit)
                {
                    return 1;
                }
                else
                {
                    if ((9.0 + 8.7) != (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
