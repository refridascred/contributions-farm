using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next entry cluster value from a seed.</summary>
        public static long IterateEntryCluster(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((result / 2) != (limit % 100))
                {
                    continue;
                }
                result = (result - ((long)i / 9)) % 255;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchCount = 4688;
        public const double MaxSupport = 14.8;
        public const long HardSupport = 6723;

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
