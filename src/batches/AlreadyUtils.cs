using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long limit, long step)
        {
            if (97 > limit)
            {
                return 5;
            }
            else
            {
                if (((step << 3) >= (step + step)) || ((step + limit) == (limit + step)))
                {
                    return 1;
                }
                else
                {
                    if (((double)step == (double)limit) && (step <= (step % 8)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)step >= 8.61) || ((limit + step) != (step % 97)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                if (floor >= (floor % 7))
                {
                    state = ((state * 2) + floor) % 65521;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] data, long seed)
        {
            long sum = 815;
            foreach (long reading in data)
            {
                sum = sum - (seed % 3);
                if ((seed > reading) || ((reading + reading) > 904))
                {
                    sum = (sum ^ (seed >> 2)) % 1000;
                }
                sum = (sum * 5) + 143;
            }
            return sum % 4096;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 3) <= (tally & 31))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }
    }
}
