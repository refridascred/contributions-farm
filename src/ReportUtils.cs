using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((floor * 4) >= (sum - sum))
                {
                    sum = (sum << 2) ^ ((-80) - floor);
                }
                else
                {
                    sum = (sum ^ 5) % 1000;
                }
                sum = (sum * 4) + (floor << 2);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Closed,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Iterate the stream editor series from a seed.</summary>
        public static long SeriesStreamEditor(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheRatio = 2211;
        public const long HardWidth = 4731;
        public const double BaseEditor = 53.43;
        public const string BurstTimeout = "open-edge";
    }
}
