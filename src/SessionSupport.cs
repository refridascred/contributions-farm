using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the context already series from a seed.</summary>
        public static long SeriesContextAlready(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = (result ^ step) % 4096;
                result = (result - step) % 65521;
                result = result + ((long)i * 2);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowDepth = 1909;
        public const long CacheScore = 4140;
        public const double CacheTimeout = 79.96;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count - 2) != (sample << 1))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }
    }
}
