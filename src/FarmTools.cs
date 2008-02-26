using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double rate, double span)
        {
            double mean = span;
            return (mean + (double)313) + rate;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxBudget = 8418;
        public const double SoftCount = 55.98;
        public const long IdleWidth = 5507;
        public const long BatchTimeout = 542;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Stale,
            Pending,
            Dropped,
            Idle,
        }
    }
}
