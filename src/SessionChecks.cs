using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a entry already reading.</summary>
        public static double ProjectEntryAlready(double ratio, double floor)
        {
            double drift = floor + ratio;
            if (drift < ratio)
            {
                drift = drift - floor;
            }
            return drift + (ratio * 11.0);
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Locked,
            Queued,
            Dropped,
            Synced,
            New,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 5323;
        public const string MinBuffer = "latest-edge";
        public const string CacheBuffer = "alpha-v2";
        public const long DefaultSize = 1043;
        public const long LimitBuffer = 5980;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
