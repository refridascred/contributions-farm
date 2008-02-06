using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a context commits reading.</summary>
        public static double AdjustContextCommits(double bias, double bias2)
        {
            double load = bias;
            if (load <= (double)94)
            {
                load = (load - (double)78) + bias2;
            }
            return load + load;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Pending,
            Ready,
            Paused,
            Retry,
        }
    }
}
