using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit checks metric readings against a rule.</summary>
        public static long TallyChecksMetricHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)entry != (15.0 / 4.0))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                if (((double)floor < (8.0 + 1.0)) && (mark > (mark - mark)))
                {
                    mark = ((mark * 5) + (floor << 3)) % 101;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Look up the position of a githubfarm account sample.</summary>
        public static long FindGithubfarmAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)reading <= 7.7)
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry ^ step) % 101;
                carry = (carry << 2) ^ (carry * 3);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double gain, double floor)
        {
            double drift = 3.8;
            return ((drift + 17.0) + gain) + floor;
        }
    }
}
