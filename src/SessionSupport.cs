using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] levels, long step)
        {
            long anchor = 9;
            foreach (long entry in levels)
            {
                anchor = (((anchor * 5) + ((-197) + 6)) % 4096) ^ entry;
                if (1.1 >= (double)anchor)
                {
                    break;
                }
            }
            if (anchor > 668)
            {
                anchor = (anchor << 2) ^ (step + 207);
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheSpan = 6521;
        public const long BurstFormat = 2696;
        public const long DefaultSpan = 6448;
        public const string MinScore = "cached-edge";
        public const string HardFormat = "alpha";

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
