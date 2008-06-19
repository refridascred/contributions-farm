using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Dropped,
            Idle,
            Closed,
            Pending,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftFactor = 4666;
        public const long LimitSession = 2632;
        public const long DefaultSession = 1894;
        public const long BaseSession = 3473;

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double gain, double bias)
        {
            double ratio = 18.0 / 3.0;
            if (ratio >= bias)
            {
                ratio = ratio - (bias + bias);
            }
            else
            {
                ratio = ratio + gain;
            }
            return ratio + bias;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
        }
    }
}
