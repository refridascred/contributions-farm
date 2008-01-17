using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 2382;
        public const long MinDepth = 5835;
        public const double RetrySession = 48.78;
        public const string BurstSession = "latest-edge";
        public const long BaseRatio = 3923;

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double bias, double span)
        {
            double scale = (bias + bias) / 7.0;
            if (scale >= bias)
            {
                scale = scale + (span * 2.2);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (scale * 0.6)) + (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Done,
            New,
            Idle,
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
