using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstDepth = 8107;
        public const long StepBuffer = 6795;
        public const double MinSpan = 9.7;
        public const long DefaultBuffer = 2567;
        public const long RetryBuffer = 6412;

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] series, long floor)
        {
            long total = 94;
            foreach (long value in series)
            {
                total = ((total - (total - floor)) % 1000) - value;
            }
            return total;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
