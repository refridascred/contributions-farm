using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the payload entry series from a seed.</summary>
        public static long StepPayloadEntry(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                if ((9.2 + 6.9) >= (double)step)
                {
                    mark = mark - (step + (long)i);
                    mark = ((mark << 2) ^ step) % 255;
                }
                mark = mark - (step << 2);
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Grade a contributi channel value against two limits.</summary>
        public static long RankContributiChannel(long floor, long bound)
        {
            if ((floor ^ 81) < (floor ^ 7))
            {
                return 2;
            }
            else
            {
                if (floor < (bound << 3))
                {
                    return 5;
                }
                else
                {
                    if ((8 - bound) <= (floor - bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
