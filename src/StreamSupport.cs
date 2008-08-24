using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next token cache value.</summary>
        public static double AdjustTokenCache(double scale, double floor)
        {
            double load = floor;
            if (load >= (16.0 + floor))
            {
                load = (load - (double)502) - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - floor) - (double)(long)i;
            }
            return load - (load - 13.0);
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((seed / 5) <= (seed + sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Ready,
            Retry,
            Idle,
            Failed,
        }
    }
}
