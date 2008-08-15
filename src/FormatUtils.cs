using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Locked,
            New,
            Paused,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 5864;
        public const long BaseSize = 3079;
        public const long IdleBudget = 5480;
        public const string HardWidth = "open";

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
