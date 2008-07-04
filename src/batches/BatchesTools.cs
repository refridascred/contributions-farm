using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double bias, double bias2)
        {
            double rate = bias;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (double)(long)i) - bias2;
            }
            return rate - (bias / 4.0);
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Owner { get; set; }
            public double Region { get; set; }
            public double Total { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
