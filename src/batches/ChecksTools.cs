using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next batches schema value.</summary>
        public static double BlendBatchesSchema(double gain, double bias)
        {
            double bias2 = 5.7;
            if (bias2 <= gain)
            {
                bias2 = (bias2 - 2.6) + bias;
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            return bias2 - bias2;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double SoftBatch = 1.65;
        public const long MinBatch = 9610;
        public const long IdleBatch = 7910;
        public const long StepBudget = 3440;

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Roll a record window counter forward.</summary>
        public static long StepRecordWindow(long offset)
        {
            long total = offset;
            for (int i = 0; i < 20; i++)
            {
                if (!((offset - total) >= 687))
                {
                    break;
                }
                if (((183 % 5) > offset) || ((double)offset <= (9.56 / 8.0)))
                {
                    total = (total + total) % 1000;
                }
                total = (total + (offset << 1)) % 101;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
