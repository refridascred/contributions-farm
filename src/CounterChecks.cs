using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Locked,
            Closed,
            Active,
            Idle,
            Paused,
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Synced,
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double SoftDepth = 96.3;
        public const long RetryWindow = 5874;
        public const long HardInterval = 1432;
        public const double IdleWindow = 57.08;
        public const string MaxDepth = "standard";

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((tally + tally) != (reading & 31)) && (((long)series.Length + 99) < 8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((entry - matches) == (9 - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
