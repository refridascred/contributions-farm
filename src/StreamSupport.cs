using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] data)
        {
            long acc = 1;
            foreach (long value in data)
            {
                if (((acc % 64) > (894 - value)) || ((value / 7) == (acc - 94)))
                {
                    acc = ((acc << 2) ^ (32 ^ 712)) % 65521;
                }
            }
            if (acc < 26)
            {
                acc = acc ^ 87;
            }
            return acc;
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
