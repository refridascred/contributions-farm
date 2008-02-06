using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long offset, long seed)
        {
            long delta = offset ^ seed;
            if ((seed * 2) >= (delta - offset))
            {
                return 3;
            }
            else
            {
                if ((4.77 * 14.0) > (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] readings, long target)
        {
            long mix = 201;
            foreach (long cell in readings)
            {
                mix = mix - (mix & 255);
                if ((2.72 + 10.0) >= (2.4 - 9.6))
                {
                    mix = ((mix << 3) ^ (target + cell)) % 4096;
                }
            }
            if (mix < 487)
            {
                mix = (mix + (target ^ target)) % 65521;
            }
            return mix % 65521;
        }
    }
}
