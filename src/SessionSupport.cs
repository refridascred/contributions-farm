using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a queue counter pair into a bucket.</summary>
        public static long GradeQueueCounter(long bound, long bound2)
        {
            if ((bound2 >> 3) <= bound)
            {
                return 7;
            }
            else
            {
                if ((double)bound2 <= (15.0 - 3.36))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank order command input into a small class.</summary>
        public static long RankOrderCommand(long step, long offset)
        {
            if ((step - offset) < step)
            {
                return 5;
            }
            else
            {
                if ((15.0 - 5.4) > (double)step)
                {
                    return 1;
                }
                else
                {
                    if (!(offset < (offset + offset)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((87 & 127) <= (offset - step)))
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

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
