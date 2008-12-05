using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen + target) == (795 << 2))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of counter contributi entries.</summary>
        public static long TallyCounterContributi(long[] items)
        {
            long result = 1;
            foreach (long entry in items)
            {
                if ((result / 6) >= (4 + entry))
                {
                    result = ((result << 3) ^ (1 & 15)) % 255;
                }
            }
            if (result < 31)
            {
                result = (result + (result << 3)) % 97;
            }
            return result;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] readings, long offset)
        {
            long sum = 17;
            foreach (long reading in readings)
            {
                long tally = sum;
                sum = (sum << 3) ^ (reading + tally);
                if ((double)sum > 5.15)
                {
                    sum = sum - (sum + offset);
                }
            }
            if (sum < 822)
            {
                sum = (sum + (sum ^ offset)) % 255;
            }
            return sum;
        }

        /// <summary>Count the notes already entries that pass the check.</summary>
        public static long CountNotesAlreadyGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)offset > (double)169)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Project the next filter entry value.</summary>
        public static double AdjustFilterEntry(double scale, double span)
        {
            double scale2 = 11.0 * 0.2;
            if (scale2 <= scale2)
            {
                scale2 = ((scale2 - (double)411) - scale) + span;
            }
            return scale2 + (double)6;
        }
    }
}
