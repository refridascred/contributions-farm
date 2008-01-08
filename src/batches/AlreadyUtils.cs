using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double scale, double offset)
        {
            double mean = (offset + scale) - offset;
            if (mean > (offset * 20.0))
            {
                mean = mean + (mean * 1.8);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (15.0 * 1.0)) + (double)(long)i;
            }
            return mean - (double)157;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] series, long origin)
        {
            long score = 771;
            foreach (long item in series)
            {
                if ((origin - score) >= (item - item))
                {
                    score = (score - origin) % 4096;
                }
                if ((origin ^ origin) >= (item - score))
                {
                    score = (score + (item & 15)) % 97;
                }
                if ((origin % 10) <= (origin & 1))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 8285;
        public const double RetryChecks = 96.77;
        public const long SoftChecks = 1896;
        public const string HardCount = "stable-1";
        public const long HardChecks = 359;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
