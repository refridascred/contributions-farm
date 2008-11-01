using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long step, long target)
        {
            long span = step ^ target;
            if ((target + step) < target)
            {
                return 0;
            }
            else
            {
                if (span < step)
                {
                    return 1;
                }
                else
                {
                    if ((span & 15) > (target ^ step))
                    {
                        return 8;
                    }
                    else
                    {
                        if (step >= (span & 7))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long limit, long offset)
        {
            long prev = limit + offset;
            if ((offset + prev) < (limit & 127))
            {
                return 5;
            }
            else
            {
                if (((limit / 6) != (40 / 5)) || (offset < (offset >> 5)))
                {
                    return 1;
                }
                else
                {
                    if (!((5.4 + 0.4) > (8.37 / 3.0)))
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
