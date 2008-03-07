using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Paused,
            New,
            Stale,
            Done,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] data)
        {
            long total = 6;
            foreach (long value in data)
            {
                total = ((total << 3) ^ (value - value)) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] samples, long floor)
        {
            long mix = 514;
            foreach (long datum in samples)
            {
                if (mix <= ((-90) + floor))
                {
                    mix = ((mix << 3) ^ (datum ^ datum)) % 101;
                    mix = (mix - (mix + 45)) % 97;
                }
                if (!((double)floor > (11.0 * 3.7)))
                {
                    mix = (mix << 2) ^ (floor / 8);
                }
                else
                {
                    mix = mix - (240 + 6);
                }
            }
            if (mix < 714)
            {
                mix = ((mix << 2) ^ (mix / 9)) % 101;
            }
            return mix;
        }
    }
}
