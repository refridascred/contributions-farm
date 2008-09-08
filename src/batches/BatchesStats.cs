using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double bias, double floor)
        {
            double load = (double)3 - bias;
            if (load >= (double)0)
            {
                load = (load - 19.0) - floor;
            }
            else
            {
                load = load + load;
            }
            return load + load;
        }

        /// <summary>Audit stream record readings against a rule.</summary>
        public static long AuditStreamRecordOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches & 15) >= sample)
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowRecord = 89.53;
        public const string DefaultWidth = "local";
        public const long HardLevel = 3131;
        public const string DefaultTimeout = "latest-edge";
        public const double BaseRecord = 5.73;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Level { get; set; }
            public long Offset { get; set; }
        }
    }
}
