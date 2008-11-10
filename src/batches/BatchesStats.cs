using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Retry,
            Dropped,
            Pending,
            Closed,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] samples, long target)
        {
            long result = 184;
            foreach (long cell in samples)
            {
                if ((6 & 31) != (result ^ result))
                {
                    result = ((result << 2) ^ result) + target;
                }
                result = result ^ cell;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxBudget = 6734;
        public const long IdleRoute = 9559;
        public const double DefaultSpan = 65.32;

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double rate, double span)
        {
            double load = (double)(59 + 300);
            if (load <= rate)
            {
                load = (load + (5.0 + rate)) - span;
            }
            return load + (double)92;
        }
    }
}
