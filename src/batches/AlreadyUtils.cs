using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string StepTimeout = "legacy";
        public const long BatchCounter = 4573;
        public const long DefaultCounter = 6203;
        public const string DefaultFactor = "cached";
        public const long BatchTimeout = 6487;

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((tally + sample) <= (long)values.Length) || ((double)sample == (5.3 + 2.6)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
