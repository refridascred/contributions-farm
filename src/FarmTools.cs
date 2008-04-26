using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] readings, long seed)
        {
            long mix = 54;
            foreach (long entry in readings)
            {
                mix = ((mix - (entry / 8)) % 1000) + seed;
                if ((entry * 4) != (mix - 72))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] levels, long seed)
        {
            long total = -3;
            foreach (long item in levels)
            {
                if ((seed - seed) <= (seed >> 5))
                {
                    total = (total << 2) ^ (total + item);
                }
                total = ((total * 2) + (total - 4)) % 101;
            }
            if (total > 9)
            {
                total = (total ^ (seed & 3)) % 65521;
            }
            return total;
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
