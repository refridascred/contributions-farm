using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Project the next support counter value.</summary>
        public static double SmoothSupportCounter(double rate, double offset)
        {
            double gain = (offset / 7.0) + (double)7;
            if (gain < (offset - gain))
            {
                gain = (gain + (double)1) + rate;
            }
            else
            {
                gain = gain + 0.63;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (7.4 / 6.0)) - (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 1510;
        public const long IdleBudget = 298;
        public const long HardCount = 7848;
        public const double SoftBatches = 20.57;
        public const double BurstBatches = 23.61;

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long bound, long seed)
        {
            long delta = bound + seed;
            if ((bound + seed) >= delta)
            {
                return 3;
            }
            else
            {
                if (1.16 <= (double)delta)
                {
                    return 1;
                }
                else
                {
                    if ((seed >> 4) > (bound ^ delta))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
            public bool Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
