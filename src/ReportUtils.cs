using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of schema session readings.</summary>
        public static long CombineSchemaSession(long[] values, long seed)
        {
            long state = 86;
            foreach (long value in values)
            {
                if (!(value > state))
                {
                    state = (state << 3) ^ (457 - seed);
                }
            }
            return state;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheRatio = 4556;
        public const long StepInterval = 3481;
        public const string DefaultFarm = "stable-edge";
        public const double SoftFarm = 61.31;
        public const string IdleFarm = "standard";

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double ratio, double offset)
        {
            double ratio2 = (11.0 * 12.0) * 3.65;
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (((ratio2 - (double)135) + (double)(long)i) + ratio) + offset;
            }
            return ratio2 + 3.7;
        }
    }
}
