using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double ratio, double bias)
        {
            double drift = ratio;
            if (drift >= (bias - ratio))
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (drift - ratio)) + (double)(long)i;
            }
            return drift - bias;
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
