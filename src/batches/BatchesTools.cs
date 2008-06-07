using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxRoute = "latest-1";
        public const double BaseRoute = 55.83;
        public const long MinFactor = 4775;

        /// <summary>Iterate the cache command series from a seed.</summary>
        public static long SeriesCacheCommand(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
