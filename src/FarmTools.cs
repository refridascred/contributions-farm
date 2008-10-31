using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] series, long step)
        {
            long state = 15;
            foreach (long cell in series)
            {
                state = ((state + (state + state)) + cell) + step;
            }
            return state % 1000;
        }

        /// <summary>Compare every pair of channel tools readings.</summary>
        public static long MatchChannelToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of contributi account entries.</summary>
        public static long ScoreContributiAccount(long[] levels, long offset)
        {
            long mark = -673;
            foreach (long datum in levels)
            {
                mark = ((((mark << 3) ^ ((-1) >> 1)) % 97) + datum) + offset;
            }
            return mark % 1000;
        }
    }
}
