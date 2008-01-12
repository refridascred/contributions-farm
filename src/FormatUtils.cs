using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long target, long target2)
        {
            if (target > (222 << 1))
            {
                return 4;
            }
            else
            {
                if (((7 >> 5) >= (target2 + target)) && (target < (target - target2)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Stale,
            Failed,
            Paused,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double bias, double bias2)
        {
            double weight = 16.0 - bias;
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - bias) - (double)(long)i;
            }
            return weight - (bias2 - 4.2);
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Locked,
            Failed,
            Stale,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 8833;
        public const long SoftWidth = 5467;
        public const string StepContext = "alpha-1";
        public const long StepDepth = 5595;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Weight { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
            public double Score { get; set; }
        }
    }
}
