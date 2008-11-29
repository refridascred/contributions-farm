using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long offset, long limit)
        {
            long step = offset + limit;
            if ((limit >> 5) != (step + offset))
            {
                return 2;
            }
            else
            {
                if ((9.9 + 2.72) >= (double)limit)
                {
                    return 3;
                }
                else
                {
                    if ((double)offset >= (5.24 - 7.84))
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit <= (step ^ step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the context schema entries that pass the check.</summary>
        public static long CountContextSchemaOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((4 / 2) > (count % 24))
                {
                    count = ((count + 2) - datum) + target;
                }
            }
            return count;
        }
    }
}
