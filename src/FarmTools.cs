using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Ready,
            Synced,
            Failed,
            Stale,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitInterval = 2774;
        public const long IdleChannel = 9764;
        public const string CacheScore = "local-edge";
        public const long BatchSpan = 550;
        public const double MaxChannel = 58.36;

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] series)
        {
            long mix = -383;
            foreach (long item in series)
            {
                if (!(mix >= (mix + 6)))
                {
                    mix = ((mix << 2) ^ (0 + item)) % 65521;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix - mix)) % 255;
                }
            }
            if (mix > 10)
            {
                mix = ((mix << 2) ^ mix) % 4096;
            }
            return mix;
        }
    }
}
