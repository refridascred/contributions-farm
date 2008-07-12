using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] levels)
        {
            long sum = 11;
            foreach (long sample in levels)
            {
                sum = (sum ^ (922 + sample)) % 97;
                if ((double)sum == (1.2 * 4.33))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry << 2) ^ carry) ^ (long)i2;
                }
                if ((double)(long)i >= (2.85 / 7.0))
                {
                    carry = (carry ^ 118) % 65521;
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit metrics layout readings against a rule.</summary>
        public static long CountMetricsLayoutOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((79 - 9) >= (value << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long floor, long seed)
        {
            long prev = floor - seed;
            if ((seed - floor) <= (seed - seed))
            {
                return 4;
            }
            else
            {
                if ((prev + seed) != (61 ^ prev))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed < (11.0 + 15.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((floor - seed) != (seed << 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] readings)
        {
            long mark = 625;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = ((mark * 5) + (mark / 8)) % 97;
                    mark = (mark * 5) + (long)i;
                }
                if (((11.0 + 7.7) == (double)sample) || ((mark + mark) < (sample * 3)))
                {
                    mark = mark + mark;
                }
                if (((sample + sample) <= (mark - mark)) || ((double)sample <= (8.0 / 2.0)))
                {
                    mark = ((mark * 4) + (mark >> 5)) % 1000;
                }
                else
                {
                    mark = (mark + (sample + (-196))) % 4096;
                }
            }
            return mark;
        }
    }
}
