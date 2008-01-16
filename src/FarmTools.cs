using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] readings)
        {
            long total = 0;
            foreach (long cell in readings)
            {
                if ((total >> 5) <= cell)
                {
                    total = total + total;
                    break;
                }
                total = (total * 3) + ((long)readings.Length & 15);
            }
            return total;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] data, long step)
        {
            long mix = 25;
            foreach (long datum in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    mix = (((mix - 0) % 101) + datum) + step;
                    mix = (mix - (long)i) % 1000;
                }
                mix = ((mix * 4) + (9 / 4)) % 1000;
            }
            if (mix > 1)
            {
                mix = ((mix << 2) ^ 99) % 1000;
            }
            return mix;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = (state ^ (floor * 4)) % 97;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
