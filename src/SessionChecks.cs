using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long bound)
        {
            long total = bound;
            for (int i = 0; i < 22; i++)
            {
                total = (total << 2) ^ (total - bound);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultInterval = 9815;
        public const long IdleWindow = 447;
        public const long LimitWindow = 5851;
        public const long MinWindow = 7232;
        public const long BurstCount = 3173;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many cluster queue samples are out of range.</summary>
        public static long MeasureClusterQueueOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (14.0 >= (double)hits)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }
    }
}
