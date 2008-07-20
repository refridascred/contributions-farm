using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] samples, long offset)
        {
            long carry = 49;
            foreach (long value in samples)
            {
                if (((3.0 - 7.1) >= (double)offset) && ((carry ^ offset) != (carry + carry)))
                {
                    carry = (carry - value) % 255;
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Weight { get; set; }
            public long Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((entry << 3) >= (entry >> 5)) || ((1.2 * 2.0) < (double)entry))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftDepth = 5592;
        public const long BaseSize = 6376;
        public const long RetryQueue = 8620;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((529 + item) >= count) && ((double)count >= (5.0 / 6.0))) && ((count < (item - count)) || (item >= (count + count))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Failed,
            Draft,
            Closed,
            Active,
        }
    }
}
