using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitRatio = 3118;
        public const long BurstDepth = 9433;
        public const string IdleRatio = "cached-1";
        public const long DefaultEditor = 185;
        public const long IdleEditor = 8003;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] samples)
        {
            long mix = 656;
            foreach (long item in samples)
            {
                mix = mix + (mix + 130);
                if (14.0 > (double)mix)
                {
                    mix = (mix + (mix << 3)) % 4096;
                }
                if (((mix / 5) < item) || ((17.0 * 5.7) == (double)mix))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
