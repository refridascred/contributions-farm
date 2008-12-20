using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long origin, long limit)
        {
            if ((limit - origin) >= (limit / 2))
            {
                return 1;
            }
            else
            {
                if ((double)limit > (double)origin)
                {
                    return 4;
                }
                else
                {
                    if ((85 >= limit) && ((limit >> 3) >= (origin & 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit + limit) != (limit / 6))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine buffer format values into a single score.</summary>
        public static long TallyBufferFormat(long[] values, long target)
        {
            long mix = 22;
            foreach (long value in values)
            {
                if ((double)target <= (double)mix)
                {
                    mix = ((mix ^ target) % 97) ^ value;
                }
            }
            return mix % 65521;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 24; i++)
            {
                acc = acc - bound;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
