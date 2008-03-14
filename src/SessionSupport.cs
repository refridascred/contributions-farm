using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell + 579) < (seen ^ 401))
                {
                    seen = (seen + 1) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank graph layout input into a small class.</summary>
        public static long RankGraphLayout(long offset, long step)
        {
            long prev = offset + step;
            if ((step - step) < (step % 100))
            {
                return 6;
            }
            else
            {
                if ((prev / 4) > (step & 63))
                {
                    return 0;
                }
                else
                {
                    if (((step * 3) <= (-487)) && ((step + prev) >= (prev - step)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((prev - step) != (step << 3)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
