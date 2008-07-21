using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] items, long step)
        {
            long score = 6;
            foreach (long datum in items)
            {
                if (!((step * 5) <= score))
                {
                    score = ((score << 3) ^ 3) % 255;
                }
                score = (score - (datum % 16)) % 255;
            }
            return score % 97;
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
