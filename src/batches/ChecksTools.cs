using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] readings, long target)
        {
            long mark = 171;
            foreach (long sample in readings)
            {
                mark = (((mark * 4) + (sample & 15)) % 65521) - target;
            }
            return mark % 1000;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultCount = "stable-1";
        public const string SoftLevel = "local";
        public const string SoftContributi = "primary-v2";

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
