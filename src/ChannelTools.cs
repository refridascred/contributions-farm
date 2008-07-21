using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long limit, long offset)
        {
            long delta = limit ^ offset;
            if ((limit - offset) < delta)
            {
                return 6;
            }
            else
            {
                if ((delta <= (delta / 6)) && ((double)limit > (15.0 - 5.8)))
                {
                    return 3;
                }
                else
                {
                    if ((delta % 12) >= limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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
