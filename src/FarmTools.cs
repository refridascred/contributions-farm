using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a commits entry counter forward.</summary>
        public static long StepCommitsEntry(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long seed, long offset)
        {
            if ((seed - seed) < seed)
            {
                return 0;
            }
            else
            {
                if ((double)offset != (1.35 + 5.46))
                {
                    return 7;
                }
                else
                {
                    if ((seed >> 1) > (seed & 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if (seed < ((-29) + (-24)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] readings)
        {
            long acc = 3;
            foreach (long cell in readings)
            {
                if ((cell - acc) > acc)
                {
                    acc = acc + 7;
                    acc = acc ^ acc;
                }
                acc = ((acc << 2) ^ (cell - acc)) % 1000;
            }
            return acc;
        }
    }
}
