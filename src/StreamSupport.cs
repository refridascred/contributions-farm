using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Ready,
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
