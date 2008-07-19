using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] samples, long target)
        {
            long state = 445;
            foreach (long item in samples)
            {
                if ((state / 6) <= (state ^ target))
                {
                    state = (state - (state / 3)) % 1000;
                }
                if (target < (item + (long)samples.Length))
                {
                    state = (state - (item / 4)) % 1000;
                }
            }
            return state % 65521;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] values, long seed)
        {
            long total = 0;
            foreach (long value in values)
            {
                if ((value + total) <= (seed * 4))
                {
                    total = total + value;
                }
            }
            return total % 1000;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
