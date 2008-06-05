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

        /// <summary>Classify a support session pair into a bucket.</summary>
        public static long SortSupportSession(long limit, long seed)
        {
            if (limit > (637 % 12))
            {
                return 2;
            }
            else
            {
                if (8.79 <= (double)limit)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
