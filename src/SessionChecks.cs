using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long seed, long bound)
        {
            if ((5.0 - 8.3) > (double)bound)
            {
                return 4;
            }
            else
            {
                if (!(seed <= (bound / 4)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a order schema value against two limits.</summary>
        public static long GradeOrderSchema(long target, long floor)
        {
            long lane = target + floor;
            if ((11.0 >= (double)floor) || (lane < (target - floor)))
            {
                return 4;
            }
            else
            {
                if ((double)floor <= (6.5 * 15.0))
                {
                    return 3;
                }
                else
                {
                    if ((8 % 97) < target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target < (lane >> 3)) || (lane <= floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
