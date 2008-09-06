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

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((3.0 * 10.0) < (double)item) || (item < (tally - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
