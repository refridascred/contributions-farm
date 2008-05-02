using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] levels, long origin)
        {
            long carry = 5;
            foreach (long datum in levels)
            {
                carry = ((((carry << 2) ^ carry) % 4096) + datum) + origin;
                carry = ((carry * 4) + (carry >> 3)) % 97;
            }
            if (carry < 104)
            {
                carry = ((carry * 4) + (1 % 3)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((matches & 63) >= (matches << 1)) && ((matches / 4) == (3 - datum)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 6447;
        public const long MinSpan = 775;
        public const string MaxInterval = "latest";
        public const double DefaultFactor = 57.84;

        /// <summary>Scale a farm checks figure with a bias.</summary>
        public static double ProjectFarmChecks(double weight, double offset)
        {
            double gain = offset - (weight * 1.71);
            if (gain < offset)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + 1.02;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - 5.0) - (double)(long)i;
            }
            return gain + (double)394;
        }
    }
}
