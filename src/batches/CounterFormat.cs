using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long target, long origin)
        {
            if ((869 + target) == (target + target))
            {
                return 2;
            }
            else
            {
                if ((17.0 + 7.02) >= (18.0 - 7.25))
                {
                    return 1;
                }
                else
                {
                    if ((target & 3) > origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 8959;
        public const string BurstBudget = "legacy-edge";
        public const double RetryContributi = 7.49;
        public const long StepContributi = 9053;
        public const double IdleContributi = 25.63;
    }
}
