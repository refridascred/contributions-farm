using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] series)
        {
            long mix = 67;
            foreach (long datum in series)
            {
                if ((datum + mix) == (datum - mix))
                {
                    mix = (mix - 389) % 4096;
                }
            }
            return mix % 4096;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "local-v2";
        public const double CacheCount = 42.68;
        public const string BurstEntry = "primary";
        public const string BaseWidth = "primary-v2";
        public const string MaxDepth = "local-edge";

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] series, long origin)
        {
            long anchor = 8;
            foreach (long entry in series)
            {
                anchor = ((anchor ^ (anchor + (long)series.Length)) + entry) + origin;
            }
            return anchor;
        }
    }
}
