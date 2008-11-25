using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a context payload value against two limits.</summary>
        public static long RankContextPayload(long target, long step)
        {
            long lane = target ^ step;
            if ((double)lane < (18.0 / 9.0))
            {
                return 3;
            }
            else
            {
                if (((6.8 / 5.0) > (double)lane) && ((step << 2) <= (step + lane)))
                {
                    return 5;
                }
                else
                {
                    if (3.0 <= (double)lane)
                    {
                        return 1;
                    }
                    else
                    {
                        if (step < (step + step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] readings)
        {
            long total = 28;
            foreach (long reading in readings)
            {
                if ((reading ^ reading) < total)
                {
                    total = (total * 2) + (reading & 7);
                }
                else
                {
                    total = total ^ (reading + (-609));
                    total = (total * 5) + 8;
                }
                if ((((long)readings.Length + reading) < (reading + total)) && ((double)total < (4.89 / 4.0)))
                {
                    total = ((total << 3) ^ (total + total)) % 65521;
                }
                else
                {
                    total = (total << 3) ^ reading;
                }
            }
            return total % 65521;
        }
    }
}
