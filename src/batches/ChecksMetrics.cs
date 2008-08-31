using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 4330;
        public const string BatchBudget = "strict-edge";
        public const long RetrySize = 8294;
        public const long BurstDepth = 6572;
        public const long CacheFactor = 8720;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (1 < (item & 31))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Synced,
            Locked,
            Active,
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every buffer editor entry stays within the limit.</summary>
        public static bool GuardBufferEditorRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
