using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a schema layout counter forward.</summary>
        public static long SeriesSchemaLayout(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                if (((1.46 + 1.89) < (double)seed) || ((sum * 3) >= (seed << 1)))
                {
                    break;
                }
                if (748 <= (sum + sum))
                {
                    sum = ((sum * 2) + seed) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryDepth = 79.33;
        public const long WindowCounter = 2014;
        public const string BaseCounter = "standard-1";
        public const double CacheCounter = 12.4;

        /// <summary>Roll a contributi entry counter forward.</summary>
        public static long SeriesContributiEntry(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] levels, long offset)
        {
            long total = 645;
            foreach (long cell in levels)
            {
                total = (total << 3) ^ (cell % 8);
                if (!((offset << 2) >= (999 / 6)))
                {
                    break;
                }
                if (cell >= (offset << 3))
                {
                    total = total - ((long)levels.Length - 6);
                }
            }
            return total;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double scale, double span)
        {
            double mean = (double)644 - span;
            return (mean - span) + scale;
        }
    }
}
