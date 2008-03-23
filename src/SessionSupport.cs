using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long step, long step2)
        {
            if ((step2 << 1) <= step)
            {
                return 8;
            }
            else
            {
                if (((step2 + step2) > (step ^ 146)) && ((step2 - step2) > (step2 - (-2))))
                {
                    return 6;
                }
                else
                {
                    if ((step2 << 1) >= (606 - step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step <= 8.22)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long mark = 14;
            foreach (long item in readings)
            {
                mark = ((mark << 2) ^ (8 + item)) % 255;
            }
            if (mark < (-83))
            {
                mark = ((mark << 3) ^ (mark + mark)) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
