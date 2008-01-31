using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 9173;
        public const string CacheLevel = "staging-1";
        public const double HardSize = 85.94;
        public const long IdleCount = 9827;
        public const string DefaultCache = "cached";

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value & 1) > (tally << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
