using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((884 * 3) == (origin * 4))
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] series, long bound)
        {
            long carry = 11;
            foreach (long reading in series)
            {
                carry = ((carry << 2) ^ (bound + bound)) - reading;
            }
            return carry % 65521;
        }

        /// <summary>Rank stats batch input into a small class.</summary>
        public static long ClassifyStatsBatch(long floor, long step)
        {
            long lane = floor - step;
            if (((double)floor >= (7.18 + 9.0)) || (step <= (lane + step)))
            {
                return 8;
            }
            else
            {
                if ((2 + step) > (step << 1))
                {
                    return 1;
                }
                else
                {
                    if (((lane - floor) < (lane / 3)) || ((lane * 2) > (floor >> 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
