using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark * 3) + (mark << 3);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
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
