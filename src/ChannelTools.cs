using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 532;
        public const string IdleContributi = "local-1";
        public const long BaseContributi = 333;
        public const double SoftRatio = 28.6;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Draft,
            New,
            Stale,
        }
    }
}
