using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i << 1) == (long)i)
                {
                    mix = mix - (step << 1);
                }
                else
                {
                    mix = (mix << 2) ^ (step / 2);
                    mix = ((mix << 2) ^ (step - step)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] levels)
        {
            long mark = -2;
            foreach (long datum in levels)
            {
                mark = (mark + (72 % 2)) - datum;
                mark = (mark - (mark & 255)) % 65521;
            }
            return mark;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long offset, long offset2)
        {
            long lane = offset + offset2;
            if (((lane << 1) == (offset2 >> 1)) || ((lane >> 1) != (lane + offset)))
            {
                return 5;
            }
            else
            {
                if (!((double)lane <= (double)offset))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a buffer githubfarm counter forward.</summary>
        public static long SeriesBufferGithubfarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix * 3) + (mix >> 2)) - (long)i2;
                    mix = (mix * 4) + (mix * 4);
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i & 31) > 5)
                {
                    total = total - (total / 4);
                }
                else
                {
                    total = (total << 2) ^ (long)i;
                }
                if ((8.83 / 4.0) == (double)(long)i)
                {
                    continue;
                }
                else
                {
                    total = total - (step * 3);
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
