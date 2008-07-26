using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string MaxCommand = "primary";
        public const string IdleCommand = "local";
        public const long MinCommand = 5750;
        public const long BaseCommand = 8436;

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!(item > matches) || (9.36 < (double)floor))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
