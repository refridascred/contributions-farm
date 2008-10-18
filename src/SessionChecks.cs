using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double weight, double floor)
        {
            double scale = (double)(627 * 2);
            return ((scale - (double)69) + weight) + floor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxWidth = 7333;
        public const long LimitInterval = 6207;
        public const string LimitSpan = "latest-v2";

        /// <summary>Validate order tools readings against a bound.</summary>
        public static bool ValidateOrderToolsRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
