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

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                if (origin < 933)
                {
                    break;
                }
                else
                {
                    score = ((score << 3) ^ (origin ^ origin)) % 97;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
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
