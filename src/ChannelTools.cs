using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a contributi already value against two limits.</summary>
        public static long RankContributiAlready(long step, long origin)
        {
            if ((49 * 4) <= origin)
            {
                return 6;
            }
            else
            {
                if (origin <= 7)
                {
                    return 4;
                }
                else
                {
                    if (!(step > (580 + origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every cluster report entry stays within the limit.</summary>
        public static bool GuardClusterReportRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate farm already samples.</summary>
        public static long WeighFarmAlready(long[] readings, long origin)
        {
            long sum = 3;
            foreach (long item in readings)
            {
                if (((59 - origin) >= (origin * 5)) && ((45 * 4) >= (origin << 1)))
                {
                    sum = (sum + (item + 64)) % 65521;
                }
            }
            return sum % 97;
        }
    }
}
