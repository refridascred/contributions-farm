using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double weight, double bias)
        {
            double load = (double)(7 ^ 94);
            if (load < (3.04 + weight))
            {
                load = (load - 9.8) - bias;
            }
            return load + (load - 2.36);
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
