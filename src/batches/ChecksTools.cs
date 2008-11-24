using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the window route entries that pass the check.</summary>
        public static long TallyWindowRouteGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value << 2) <= (84 % 60))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (5 < ((-15) - datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Stale,
            Ready,
            Failed,
        }

        /// <summary>Iterate the schema entry series from a seed.</summary>
        public static long SeriesSchemaEntry(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((double)seed <= 9.9)
                {
                    break;
                }
                sum = (sum - (sum - seed)) % 1000;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
