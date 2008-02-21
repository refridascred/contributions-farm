using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (hits <= (value & 127))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MaxCount = "primary";
        public const long StepWidth = 7155;
        public const long DefaultFormat = 3154;
        public const long BaseFormat = 5376;

        /// <summary>Iterate the record filter series from a seed.</summary>
        public static long StepRecordFilter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 5; i++)
            {
                sum = sum ^ ((long)i ^ 12);
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 1268;
        public const string LimitOrder = "local";
        public const double StepOrder = 71.29;
        public const long SoftDepth = 6584;
        public const string BatchInterval = "standard";

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Count { get; set; } = "";
            public double Mode { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 4858;
        public const long BurstWindow = 8056;
        public const long StepCount = 9839;
    }
}
