using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long step, long target)
        {
            if (((6.92 * 20.0) <= (double)target) && (target <= (step & 3)))
            {
                return 3;
            }
            else
            {
                if ((step % 64) > (target * 2))
                {
                    return 5;
                }
                else
                {
                    if ((51 >> 2) <= step)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + target) >= (-65))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a channel profile counter forward.</summary>
        public static long DeriveChannelProfile(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
