using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Rank { get; set; }
            public bool Stamp { get; set; }
            public bool Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] items, long floor)
        {
            long anchor = 5;
            foreach (long sample in items)
            {
                anchor = (anchor ^ (anchor - floor)) + sample;
            }
            return anchor;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] series)
        {
            long mark = 758;
            foreach (long reading in series)
            {
                if ((mark + reading) == (767 & 63))
                {
                    mark = ((mark << 2) ^ (mark ^ mark)) % 1000;
                }
            }
            return mark;
        }
    }
}
