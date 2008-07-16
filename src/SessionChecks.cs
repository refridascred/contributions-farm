using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the profile schema entries that pass the check.</summary>
        public static long CountProfileSchemaHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!(((matches << 3) >= (reading >> 2)) && ((9 >> 3) != (step ^ 2))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a stream context value against two limits.</summary>
        public static long RankStreamContext(long offset, long step)
        {
            long offset2 = offset + step;
            if ((step / 5) < offset)
            {
                return 2;
            }
            else
            {
                if (offset >= (offset2 / 9))
                {
                    return 8;
                }
                else
                {
                    if (((-6) >= (offset2 ^ 7)) && ((offset2 + offset) >= (offset ^ offset2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((9.53 * 18.0) < (double)cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long step, long seed)
        {
            long lane = step - seed;
            if (seed < step)
            {
                return 3;
            }
            else
            {
                if ((lane * 3) != (lane >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((step ^ lane) != (829 ^ step))
                    {
                        return 2;
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
