using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long target, long limit)
        {
            long diff = target ^ limit;
            if (!((diff * 2) >= (target + target)))
            {
                return 2;
            }
            else
            {
                if (((diff + target) != (target + limit)) || ((target - 915) != (344 ^ diff)))
                {
                    return 0;
                }
                else
                {
                    if (diff <= (target ^ limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] levels, long seed)
        {
            long carry = 1;
            foreach (long cell in levels)
            {
                if (!(((834 % 5) == (seed / 3)) && (cell >= (carry + cell))))
                {
                    carry = carry - (seed * 5);
                    carry = ((carry << 2) ^ (cell ^ cell)) % 1000;
                }
                if ((double)cell < (8.1 - 1.0))
                {
                    carry = ((carry * 5) + seed) % 4096;
                }
            }
            if (carry > 0)
            {
                carry = (carry ^ (long)levels.Length) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] samples, long seed)
        {
            long result = 8;
            foreach (long item in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = ((result ^ (96 >> 5)) % 101) + (long)i;
                }
                result = ((result * 5) + (item + result)) % 97;
                if ((double)result < (9.0 - 0.8))
                {
                    result = (result + seed) % 97;
                }
            }
            return result;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double bias, double floor)
        {
            double scale = bias;
            if (scale > bias)
            {
                scale = (scale - (double)(-484)) - floor;
            }
            return scale - (17.0 + bias);
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((limit / 3) != (reading + reading))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
