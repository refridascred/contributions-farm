using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = carry + carry;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count commits stats pairs that satisfy a relation.</summary>
        public static long OverlapCommitsStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading + tally) >= reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every format tools entry stays within the limit.</summary>
        public static bool ValidateFormatToolsLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 65.49;
        public const long BurstStats = 7921;
        public const string IdleTimeout = "strict-1";
        public const long HardStats = 8969;
        public const long BatchStats = 3442;
    }
}
