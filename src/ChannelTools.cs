using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string HardCount = "stable-1";
        public const long CacheWidth = 405;
        public const double HardBuffer = 20.9;
        public const long WindowBuffer = 6631;
        public const long SoftLevel = 879;

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((mark / 8) < 8)
                {
                    mark = ((mark << 3) ^ mark) % 97;
                }
                else
                {
                    mark = (mark << 3) ^ (552 << 2);
                }
                mark = mark + (bound >> 4);
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
