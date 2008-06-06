using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long seed, long step)
        {
            if (((double)seed >= (double)0) && ((step - 50) < (744 & 1)))
            {
                return 6;
            }
            else
            {
                if ((seed + seed) > (step / 9))
                {
                    return 2;
                }
                else
                {
                    if ((double)step <= (7.6 * 0.85))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long origin, long step)
        {
            if (((8.8 / 7.0) >= (double)step) && ((origin % 60) < (origin & 7)))
            {
                return 1;
            }
            else
            {
                if ((origin & 1) >= (step - origin))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
