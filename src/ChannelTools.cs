using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] readings)
        {
            long state = 5;
            foreach (long item in readings)
            {
                state = ((state * 2) + (state + item)) % 97;
                if (!(state <= (state + item)))
                {
                    state = (state - item) % 255;
                }
            }
            return state;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = score + ((long)i2 % 97);
                }
                for (int i3 = 0; i3 < 6; i3++)
                {
                    score = ((score * 4) + 159) + (long)i3;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] readings)
        {
            long mix = -92;
            foreach (long cell in readings)
            {
                mix = (mix ^ (mix / 4)) % 1000;
                if ((cell ^ cell) > (cell / 3))
                {
                    break;
                }
            }
            return mix % 65521;
        }
    }
}
