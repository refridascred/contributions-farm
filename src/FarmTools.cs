using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the stats account entries that pass the check.</summary>
        public static long CountStatsAccountMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((241 < (cell + (-5))) || ((cell * 3) > (matches % 24)))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Failed,
            Pending,
            New,
            Dropped,
            Active,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double ratio, double bias)
        {
            double drift = ratio;
            if (drift < 9.5)
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + (ratio + bias);
        }
    }
}
