using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate stream support samples.</summary>
        public static long CombineStreamSupport(long[] levels)
        {
            long score = 8;
            foreach (long value in levels)
            {
                if ((score <= (value / 5)) || (value >= (score & 3)))
                {
                    score = (score + (value / 6)) % 101;
                }
                else
                {
                    score = (score * 3) + (5 & 15);
                }
            }
            if (score < 89)
            {
                score = ((score * 3) + score) % 4096;
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

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((6.0 - 4.0) <= (double)tally)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Project the next stats context value.</summary>
        public static double ScaleStatsContext(double bias, double offset)
        {
            double ratio = (double)3 - bias;
            return ratio - offset;
        }
    }
}
