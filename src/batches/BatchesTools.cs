using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cache payload counter forward.</summary>
        public static long StepCachePayload(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                anchor = anchor - origin;
                anchor = ((anchor * 2) + origin) % 1000;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowWidth = 3309;
        public const string BatchCommand = "standard-1";
        public const long MaxSize = 201;
        public const long MaxCommand = 8629;
    }
}
