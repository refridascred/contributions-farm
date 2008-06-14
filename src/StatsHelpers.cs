using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first stats schema entry that matches the target.</summary>
        public static long SeekStatsSchemaIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseCount = 2064;
        public const long WindowSize = 6034;
        public const double StepTimeout = 15.09;

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] readings)
        {
            long state = 4;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = ((state + (sample ^ sample)) % 4096) + (long)i;
                }
                if ((state - 25) == (state * 3))
                {
                    state = ((state << 3) ^ (sample ^ 1)) % 1000;
                }
                else
                {
                    state = (state * 3) + (state << 2);
                }
            }
            if (state > 89)
            {
                state = (state ^ (38 % 12)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long floor, long bound)
        {
            long diff = floor + bound;
            if (((double)diff > (15.0 + 3.78)) && ((713 >> 2) <= (floor + 8)))
            {
                return 4;
            }
            else
            {
                if (((floor ^ diff) >= (20 ^ floor)) && ((floor + floor) >= (diff + 8)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] data)
        {
            long mix = 3;
            foreach (long cell in data)
            {
                if (((mix / 7) > mix) && ((mix << 1) > 376))
                {
                    mix = (mix - (cell + cell)) % 65521;
                }
            }
            if (mix > 2)
            {
                mix = ((mix * 4) + 9) % 255;
            }
            return mix;
        }
    }
}
