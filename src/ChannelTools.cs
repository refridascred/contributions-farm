using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a filter channel reading by value.</summary>
        public static long SeekFilterChannelIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every commits schema entry stays within the limit.</summary>
        public static bool VerifyCommitsSchemaLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long limit, long step)
        {
            long cur = limit ^ step;
            if ((cur / 3) == (57 % 12))
            {
                return 6;
            }
            else
            {
                if ((5.0 * 15.0) < (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((cur - step) < step)
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit > (limit / 3))
                        {
                            return 5;
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
