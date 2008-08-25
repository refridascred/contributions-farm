using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 132;
        public const double BaseNotes = 12.99;
        public const double StepRatio = 11.85;
        public const long MaxDepth = 327;

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                if (((18.0 * 1.0) > (double)bound) && ((double)result >= 6.67))
                {
                    continue;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Active,
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Audit stream report readings against a rule.</summary>
        public static long CountStreamReportOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches & 3) <= cell)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate token buffer readings against a bound.</summary>
        public static bool CheckTokenBufferLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
