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

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
