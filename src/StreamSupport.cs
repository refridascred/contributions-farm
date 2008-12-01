using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the checks buffer series from a seed.</summary>
        public static long StepChecksBuffer(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum ^ (seed - seed)) % 65521;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long step, long floor)
        {
            if ((64 / 7) >= (floor >> 1))
            {
                return 2;
            }
            else
            {
                if (((floor - 981) >= step) || ((step << 2) != (floor / 8)))
                {
                    return 6;
                }
                else
                {
                    if ((floor / 9) == (21 - step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(7.24 >= (3.7 * 7.1)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the support batch entries that pass the check.</summary>
        public static long TallySupportBatchGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches >= (matches * 3))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }
    }
}
