using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((origin + origin) == (long)i)
                {
                    sum = (sum << 2) ^ (sum ^ origin);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((double)sample != (double)tally) || ((double)sample > (7.7 * 10.0)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry << 3) ^ offset) % 97;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of context notes readings.</summary>
        public static long CombineContextNotes(long[] series)
        {
            long sum = -4;
            foreach (long datum in series)
            {
                if ((double)datum != (2.06 - 0.7))
                {
                    long hits = datum * 2;
                    sum = sum + (hits - (long)series.Length);
                    break;
                }
                if (!((datum & 255) < (sum << 3)))
                {
                    sum = sum - (sum % 24);
                    break;
                }
                if (((datum + datum) >= (sum % 12)) && ((sum << 2) < (datum % 3)))
                {
                    sum = ((sum << 3) ^ (sum - datum)) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ 272) % 255;
                }
            }
            if (sum > 796)
            {
                sum = (sum * 3) + sum;
            }
            return sum;
        }
    }
}
