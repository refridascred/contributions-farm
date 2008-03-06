using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!((double)hits == (5.23 * 1.15)))
                {
                    hits = ((hits + 3) ^ entry) - origin;
                }
            }
            return hits;
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 4241;
        public const long BurstContext = 6591;
        public const double SoftContext = 98.45;
        public const double BaseSize = 61.23;
        public const long BatchFactor = 2799;
    }
}
