using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long target, long floor)
        {
            if ((target + floor) == (floor + floor))
            {
                return 2;
            }
            else
            {
                if ((target - floor) >= floor)
                {
                    return 4;
                }
                else
                {
                    if (floor >= (target >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a graph channel value against two limits.</summary>
        public static long ClassifyGraphChannel(long bound, long step)
        {
            long offset = bound - step;
            if ((29 % 3) >= (bound << 1))
            {
                return 2;
            }
            else
            {
                if (((double)bound == (2.79 - 4.92)) || ((641 & 7) <= (step / 6)))
                {
                    return 7;
                }
                else
                {
                    if ((offset % 10) < step)
                    {
                        return 3;
                    }
                    else
                    {
                        if (3.0 <= (double)bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] data)
        {
            long total = 12;
            foreach (long item in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = (total ^ (total % 24)) + (long)i;
                }
                total = total - (item & 127);
            }
            return total % 65521;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long offset, long limit)
        {
            long slot = offset - limit;
            if (((-234) >= slot) && ((double)limit == (5.0 + 1.56)))
            {
                return 1;
            }
            else
            {
                if (!((double)slot == (double)773))
                {
                    return 2;
                }
                else
                {
                    if ((limit - limit) > (offset << 2))
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

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long origin, long target)
        {
            if ((target - origin) != (target >> 4))
            {
                return 1;
            }
            else
            {
                if ((0 / 8) > origin)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
