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

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
