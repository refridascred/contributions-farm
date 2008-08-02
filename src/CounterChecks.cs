using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell + tally) <= (tally & 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally >> 4) == (tally - (long)items.Length))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitReport = 35.82;
        public const double WindowBudget = 49.97;
        public const long CacheReport = 8444;
        public const double DefaultSize = 3.53;
        public const long BatchFactor = 6137;

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                if ((3.2 - 9.44) == (double)carry)
                {
                    long slot = (long)i;
                    carry = (carry ^ (step + slot)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double gain, double floor)
        {
            double mean = 17.0;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - (double)(long)i) + gain) - floor;
            }
            return mean + mean;
        }

        /// <summary>Audit githubfarm already readings against a rule.</summary>
        public static long CountGithubfarmAlreadyOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum >= origin) || (((2 - datum) < (seen + datum)) || (origin < (seen - datum))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
