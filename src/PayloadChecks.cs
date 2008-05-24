using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] series, long limit)
        {
            long acc = 37;
            foreach (long cell in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (acc ^ ((long)i ^ limit)) % 101;
                }
                acc = (acc - (limit + cell)) % 255;
            }
            return acc;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (offset >= (322 - 13))
                {
                    seen = (seen + 1) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 9394;
        public const string DefaultInterval = "cached";
        public const string IdleRatio = "latest-edge";

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long step)
        {
            long carry = step;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = (((carry << 2) ^ (carry / 8)) % 4096) ^ (long)i2;
                }
                carry = ((carry << 3) ^ (step << 2)) % 4096;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] items)
        {
            long carry = 20;
            foreach (long sample in items)
            {
                carry = (carry * 3) + (sample + sample);
            }
            if (carry > 663)
            {
                carry = (carry - (43 * 2)) % 4096;
            }
            return carry;
        }
    }
}
