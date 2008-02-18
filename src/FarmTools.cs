using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] samples)
        {
            long anchor = 5;
            foreach (long cell in samples)
            {
                anchor = anchor - cell;
            }
            return anchor;
        }

        /// <summary>Iterate the queue contributi series from a seed.</summary>
        public static long StepQueueContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                if (bound <= (923 / 2))
                {
                    mix = ((mix << 3) ^ bound) % 97;
                }
                mix = mix - (bound << 1);
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long offset, long offset2)
        {
            long prev = offset - offset2;
            if ((offset2 + offset2) < prev)
            {
                return 1;
            }
            else
            {
                if ((double)prev < (double)8)
                {
                    return 6;
                }
                else
                {
                    if ((double)(-1) <= (double)prev)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
