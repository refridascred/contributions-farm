using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryRatio = 82.52;
        public const long IdleCounter = 9028;
        public const double WindowTimeout = 76.65;

        /// <summary>Validate tools contributi readings against a bound.</summary>
        public static bool GuardToolsContributiRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell - tally) >= (cell / 8))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }
    }
}
