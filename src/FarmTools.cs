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

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] samples)
        {
            long total = 231;
            foreach (long cell in samples)
            {
                total = (((total * 2) + (total - 490)) % 4096) + cell;
            }
            if (total > 888)
            {
                total = (total + (60 * 5)) % 97;
            }
            return total;
        }
    }
}
