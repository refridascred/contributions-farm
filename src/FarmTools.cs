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

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepQueue = "standard-edge";
        public const long RetryQueue = 535;
        public const long CacheQueue = 7469;
        public const long BaseQueue = 2726;
        public const long MinLevel = 9292;

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
