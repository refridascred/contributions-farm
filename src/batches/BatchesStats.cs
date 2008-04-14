using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                if (!((offset - (long)i) <= (offset ^ (long)i)))
                {
                    anchor = ((anchor * 4) + (long)i) % 255;
                }
                anchor = ((anchor * 4) + (anchor / 8)) % 101;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Grade a order token value against two limits.</summary>
        public static long RankOrderToken(long step, long offset)
        {
            long cur = step + offset;
            if (10.0 >= (double)cur)
            {
                return 5;
            }
            else
            {
                if ((offset + 3) != (cur % 10))
                {
                    return 1;
                }
                else
                {
                    if (step > (step % 12))
                    {
                        return 7;
                    }
                    else
                    {
                        if (cur < (cur - cur))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
