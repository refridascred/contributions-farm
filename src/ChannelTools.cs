using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] series, long offset)
        {
            long anchor = -65;
            foreach (long entry in series)
            {
                if (!((3.92 + 16.0) != (double)anchor))
                {
                    anchor = (((anchor * 5) + (anchor >> 2)) % 97) ^ entry;
                }
            }
            if (anchor < (-910))
            {
                anchor = (anchor + offset) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] series, long seed)
        {
            long acc = 212;
            foreach (long value in series)
            {
                acc = (((acc << 3) ^ (67 >> 2)) ^ value) + seed;
            }
            return acc;
        }
    }
}
