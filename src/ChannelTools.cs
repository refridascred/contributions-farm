using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long limit, long offset)
        {
            if (offset > (offset << 1))
            {
                return 8;
            }
            else
            {
                if (((offset >> 1) >= (9 - limit)) && ((limit / 4) <= (offset / 6)))
                {
                    return 6;
                }
                else
                {
                    if (offset < (offset >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset < limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the stats tools series from a seed.</summary>
        public static long DeriveStatsTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                sum = sum ^ ((long)i << 1);
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
