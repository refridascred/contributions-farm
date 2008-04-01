using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many context session samples are out of range.</summary>
        public static long TallyContextSessionHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((seen ^ seen) <= (cell % 12)))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheLevel = 5.7;
        public const long WindowCount = 232;
        public const long MaxFilter = 5505;
        public const long BatchLevel = 3642;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 7085;
        public const long CacheDepth = 7343;
        public const long WindowBuffer = 4884;
        public const string HardBuffer = "stable-v2";
    }
}
