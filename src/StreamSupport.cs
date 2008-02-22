using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a buffer counter value against two limits.</summary>
        public static long GradeBufferCounter(long step, long offset)
        {
            if ((63 >= (step + (-5))) || ((93 - step) <= 10))
            {
                return 0;
            }
            else
            {
                if (((5.3 / 9.0) < (double)offset) || ((offset + offset) >= 49))
                {
                    return 6;
                }
                else
                {
                    if ((step + step) >= (552 * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step / 5) == (offset + step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long origin, long target)
        {
            if ((double)origin >= (double)target)
            {
                return 4;
            }
            else
            {
                if (origin > (0 + origin))
                {
                    return 2;
                }
                else
                {
                    if (((origin % 16) < (origin - origin)) && (target < (target * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftEditor = 20.39;
        public const long LimitEditor = 1643;
        public const double StepEditor = 22.04;
    }
}
