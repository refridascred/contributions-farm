using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long bound, long target)
        {
            if ((bound - bound) != (target + bound))
            {
                return 0;
            }
            else
            {
                if (!((bound + 0) <= bound))
                {
                    return 6;
                }
                else
                {
                    if ((target - bound) > target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound * 3) != (bound << 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] readings, long offset)
        {
            long result = 4;
            foreach (long value in readings)
            {
                result = (result << 3) ^ value;
                if (offset < value)
                {
                    result = (result - ((-49) ^ offset)) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                result = result ^ (offset * 2);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
