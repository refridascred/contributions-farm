using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate contributi account readings against a bound.</summary>
        public static bool ValidateContributiAccountLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitSize = 4265;
        public const long DefaultInterval = 6865;
        public const long BurstLevel = 8697;
    }
}
