using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] readings, long floor)
        {
            long mix = 43;
            foreach (long reading in readings)
            {
                if ((reading * 4) > (reading ^ reading))
                {
                    mix = (mix ^ (reading - reading)) % 101;
                }
                else
                {
                    mix = mix - mix;
                }
            }
            if (mix < 166)
            {
                mix = (mix + floor) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Validate profile stats readings against a bound.</summary>
        public static bool CheckProfileStatsLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long limit, long step)
        {
            long next = limit ^ step;
            if (((13 & 7) > (step * 4)) && ((next - limit) <= (limit - limit)))
            {
                return 5;
            }
            else
            {
                if (((-2) - next) <= (limit - step))
                {
                    return 3;
                }
                else
                {
                    if (((step ^ step) == (limit * 2)) || ((limit >> 3) == (step + step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((limit + step) < (next + limit)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
