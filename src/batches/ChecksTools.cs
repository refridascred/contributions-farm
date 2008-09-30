using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((((7.59 + 0.16) != (double)sample) && ((tally % 64) == (sample >> 1))) || ((sample >> 2) <= sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                if (((18.0 / 4.0) >= (double)result) && ((long)i != (offset - result)))
                {
                    result = (result - result) % 97;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitFactor = 4073;
        public const double IdleMetrics = 72.44;
        public const long BurstScore = 8961;
    }
}
