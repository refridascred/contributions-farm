using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 2232;
        public const double IdleEntry = 79.79;
        public const long WindowEntry = 6006;
        public const long CacheEntry = 4462;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Closed,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Iterate the stream editor series from a seed.</summary>
        public static long SeriesStreamEditor(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                if (((16.0 / 3.0) < (double)(long)i) || ((double)mix <= (double)target))
                {
                    mix = (mix ^ (mix - 8)) % 65521;
                }
                if (((target & 255) == (mix + mix)) && ((mix % 100) > mix))
                {
                    mix = ((mix << 2) ^ 20) % 65521;
                }
                if (!((double)target > (double)(long)i))
                {
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheRatio = 2211;
        public const long HardWidth = 4731;
        public const double BaseEditor = 53.43;
        public const string BurstTimeout = "open-edge";
    }
}
