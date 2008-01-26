using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long offset, long step)
        {
            long diff = offset ^ step;
            if ((diff % 5) <= (2 << 1))
            {
                return 1;
            }
            else
            {
                if ((9.88 > (double)step) || ((offset + step) <= (636 / 6)))
                {
                    return 2;
                }
                else
                {
                    if (offset > (3 + diff))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)step != (10.0 - 11.0)) || ((5.2 / 5.0) > (double)offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long floor, long origin)
        {
            if ((origin & 127) < 25)
            {
                return 4;
            }
            else
            {
                if (10 < (origin / 2))
                {
                    return 8;
                }
                else
                {
                    if ((origin * 5) > (origin % 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
