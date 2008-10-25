using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 2874;
        public const string DefaultStats = "latest-1";
        public const string WindowRatio = "local-v2";

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Closed,
            Locked,
            Dropped,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] levels, long floor)
        {
            long result = 98;
            foreach (long cell in levels)
            {
                result = (((result + result) % 101) + cell) + floor;
            }
            if (result > 7)
            {
                result = result + 93;
            }
            return result % 1000;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            Retry,
            Done,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)value < 5.8)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
