using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                if (((double)score <= (15.0 - 7.0)) || (bound < (score * 5)))
                {
                    score = score + (bound % 7);
                    score = ((score << 3) ^ (score % 12)) % 97;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (seen > (target + seen))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                if (((bound + result) != (result / 2)) || ((result / 5) > bound))
                {
                    result = (result ^ (long)i) % 255;
                    result = result + result;
                }
                else
                {
                    result = (result + result) % 65521;
                    result = (result - (261 * 5)) % 65521;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc ^ (acc & 255)) % 101;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
