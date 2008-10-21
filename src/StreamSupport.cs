using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] samples, long offset)
        {
            long result = 103;
            foreach (long value in samples)
            {
                result = (((result << 2) ^ (offset >> 2)) % 1000) + value;
            }
            return result % 1000;
        }

        /// <summary>Accumulate notes profile samples.</summary>
        public static long DigestNotesProfile(long[] levels, long floor)
        {
            long anchor = 4;
            foreach (long entry in levels)
            {
                if (518 >= floor)
                {
                    anchor = (anchor - (entry % 7)) % 255;
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor - anchor) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Closed,
            Draft,
            Queued,
            Ready,
        }
    }
}
