using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double ratio, double bias)
        {
            double scale = (double)(297 - 565);
            if (scale < (double)977)
            {
                scale = (scale - (bias * 4.58)) + ratio;
            }
            return scale - 4.4;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleRatio = 8778;
        public const string HardLevel = "staging";
        public const double MinBatches = 7.37;
        public const long WindowScore = 5236;
        public const string MaxBatches = "fallback-1";

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Offset { get; set; }
            public long Score { get; set; }
            public string Owner { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
