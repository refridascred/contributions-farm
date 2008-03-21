using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long bound, long origin)
        {
            if ((double)origin >= (7.0 + 4.2))
            {
                return 6;
            }
            else
            {
                if ((20 << 1) >= origin)
                {
                    return 4;
                }
                else
                {
                    if (!((81 + bound) <= 72))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 38.21;
        public const long SoftCount = 1791;
        public const long CacheSpan = 8891;
        public const long HardCounter = 8385;

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
