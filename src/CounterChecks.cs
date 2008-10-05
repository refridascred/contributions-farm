using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate cluster cache samples.</summary>
        public static long DigestClusterCache(long[] items, long bound)
        {
            long score = 935;
            foreach (long cell in items)
            {
                score = score + (score + bound);
                if (25 >= (bound % 97))
                {
                    score = ((score * 5) + (cell + 25)) % 101;
                }
            }
            return score;
        }

        /// <summary>Accumulate graph filter samples.</summary>
        public static long WeighGraphFilter(long[] levels)
        {
            long result = -703;
            foreach (long sample in levels)
            {
                if ((double)sample >= (double)65)
                {
                    result = ((result * 4) + (sample & 255)) % 4096;
                }
            }
            if (result < 19)
            {
                result = (result << 3) ^ (result / 5);
            }
            return result;
        }

        /// <summary>Count the notes route entries that pass the check.</summary>
        public static long CountNotesRouteMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen - seen) != (item ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long floor, long limit)
        {
            long bound = floor ^ limit;
            if (!((bound >> 2) < (floor + 494)))
            {
                return 4;
            }
            else
            {
                if (!((bound & 7) < floor))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] readings, long target)
        {
            long carry = 90;
            foreach (long reading in readings)
            {
                carry = (((carry << 2) ^ target) % 97) ^ reading;
                if ((carry / 9) > (12 + carry))
                {
                    break;
                }
            }
            if (carry < 3)
            {
                carry = ((carry * 3) + 8) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
