using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowDepth = 47.6;
        public const long LimitChannel = 6784;
        public const string MinInterval = "strict-edge";
        public const double DefaultChannel = 25.17;
        public const long WindowChannel = 9805;

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] values)
        {
            long mix = 782;
            foreach (long value in values)
            {
                if ((value / 3) == (value % 5))
                {
                    mix = (mix * 4) + (32 ^ value);
                }
                else
                {
                    mix = ((mix << 2) ^ ((long)values.Length << 3)) % 4096;
                }
            }
            if (mix < 925)
            {
                mix = (mix * 5) + (874 - 6);
            }
            return mix % 1000;
        }

        /// <summary>Validate layout schema readings against a bound.</summary>
        public static bool ValidateLayoutSchemaRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Level { get; set; }
            public bool Flag { get; set; }
            public double Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Retry,
            Stale,
            Closed,
            Locked,
            Synced,
        }
    }
}
