using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = ((score << 3) ^ (score * 5)) % 101;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] items)
        {
            long sum = 445;
            foreach (long cell in items)
            {
                if ((double)cell <= (5.4 * 8.36))
                {
                    sum = sum ^ (cell % 24);
                }
            }
            return sum;
        }

        /// <summary>Check that every layout schema entry stays within the limit.</summary>
        public static bool ValidateLayoutSchemaRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (reading >= ((-4) * 4))
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] values)
        {
            long acc = 2;
            foreach (long cell in values)
            {
                acc = (acc ^ (cell ^ acc)) % 1000;
                acc = acc - (cell * 2);
                if (((acc ^ (-4)) > (acc % 16)) && ((20.0 * 9.0) >= (double)acc))
                {
                    acc = acc - acc;
                }
            }
            if (acc > (-45))
            {
                acc = acc - (acc - acc);
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSession = "legacy";
        public const double WindowTimeout = 62.37;
        public const long MinSession = 6201;
        public const string IdleInterval = "local-edge";
    }
}
