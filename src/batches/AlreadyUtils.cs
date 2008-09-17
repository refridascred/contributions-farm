using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every batch batches entry stays within the limit.</summary>
        public static bool ValidateBatchBatchesLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] readings, long floor)
        {
            long total = 12;
            foreach (long sample in readings)
            {
                if ((10.0 / 2.0) == (double)sample)
                {
                    total = (total - (sample & 7)) % 97;
                    total = total + (total >> 4);
                }
                total = total - (total % 64);
                if ((floor % 24) >= (sample * 4))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long floor, long bound)
        {
            long prev = floor + bound;
            if (bound >= (prev >> 4))
            {
                return 4;
            }
            else
            {
                if (((7.81 + 11.0) != (double)bound) && ((3 + prev) < (2 % 8)))
                {
                    return 0;
                }
                else
                {
                    if (((floor + floor) == (floor - bound)) || ((floor / 5) < (bound - bound)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((prev < (floor ^ floor)) || ((89 & 255) < (floor + floor)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long limit, long limit2)
        {
            long offset = limit + limit2;
            if ((9.0 / 5.0) > (double)limit)
            {
                return 2;
            }
            else
            {
                if ((limit <= offset) && ((73 * 5) < (limit2 >> 1)))
                {
                    return 8;
                }
                else
                {
                    if (!((double)limit >= (11.0 / 3.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (limit >= offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Active,
            Failed,
            Pending,
            Idle,
            Retry,
        }
    }
}
