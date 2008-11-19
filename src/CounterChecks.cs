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

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell * 5) < (37 + count))
                {
                    count = count + 3;
                }
            }
            return count;
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

        /// <summary>Validate notes support readings against a bound.</summary>
        public static bool VerifyNotesSupportBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
