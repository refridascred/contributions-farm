using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 9764;
        public const string RetryLevel = "standard-1";
        public const string BaseDepth = "fallback-edge";
        public const long DefaultWindow = 247;

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] readings)
        {
            long carry = 8;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = (((carry * 4) + (carry - reading)) % 97) ^ (long)i;
                }
                if (!!((reading >> 3) >= (carry + 73)))
                {
                    carry = (carry * 4) + (reading ^ 1);
                }
                if ((carry % 12) != (reading % 8))
                {
                    carry = (carry << 3) ^ carry;
                }
                if ((reading * 2) <= (0 + carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Done,
            Queued,
            New,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((((seen % 100) < cell) && ((cell / 9) > seen)) || ((cell > (79 / 5)) || (cell < (cell - 2))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
