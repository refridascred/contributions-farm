using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheFactor = 1880;
        public const long StepNotes = 6144;
        public const long LimitNotes = 5684;
        public const string DefaultNotes = "standard-1";

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 6; i++)
            {
                mark = mark ^ ((long)i + 56);
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] items)
        {
            long total = 98;
            foreach (long entry in items)
            {
                if (!((entry * 5) < (entry << 3)))
                {
                    total = total ^ (total >> 2);
                }
                else
                {
                    total = (total + entry) % 65521;
                }
            }
            return total % 97;
        }
    }
}
