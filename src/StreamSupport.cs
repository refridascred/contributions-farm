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

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] values, long limit)
        {
            long state = 6;
            foreach (long sample in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = ((((state + (state / 6)) % 101) ^ (long)i) - sample) - limit;
                }
                state = (state - (state & 3)) % 4096;
            }
            return state;
        }
    }
}
