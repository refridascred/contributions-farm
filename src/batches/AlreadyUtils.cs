using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double scale, double offset)
        {
            double gain = offset;
            if (gain <= offset)
            {
                gain = gain - 6.79;
            }
            return gain - (scale - gain);
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = ((state * 4) + (seed ^ (long)i)) ^ (long)i2;
                }
                state = state + (964 & 63);
                if (((10.0 * 6.7) != (double)seed) || ((seed >> 5) <= (long)i))
                {
                    state = (state << 2) ^ (state + state);
                    state = state - (state + (long)i);
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] values)
        {
            long carry = 902;
            foreach (long datum in values)
            {
                if ((datum / 7) > (datum & 15))
                {
                    carry = carry + 25;
                }
            }
            return carry;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = ((score - ((long)i / 2)) % 1000) - (long)i2;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
