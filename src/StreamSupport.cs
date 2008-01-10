using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate order window readings against a bound.</summary>
        public static bool GuardOrderWindowRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long target, long step)
        {
            long bound = target ^ step;
            if ((bound - bound) < (step & 255))
            {
                return 0;
            }
            else
            {
                if (((double)bound >= (double)step) && ((step - target) <= (step >> 2)))
                {
                    return 2;
                }
                else
                {
                    if ((6.0 + 1.0) < (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank buffer command input into a small class.</summary>
        public static long BucketBufferCommand(long origin, long seed)
        {
            long prev = origin ^ seed;
            if ((double)prev == (double)origin)
            {
                return 8;
            }
            else
            {
                if ((0 >> 2) >= (seed & 15))
                {
                    return 3;
                }
                else
                {
                    if (((origin << 1) > origin) && (prev <= origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)4 < (double)prev)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
