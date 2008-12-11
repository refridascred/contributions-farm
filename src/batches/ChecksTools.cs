using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a layout order figure with a bias.</summary>
        public static double ProjectLayoutOrder(double gain, double span)
        {
            double gain2 = span;
            return (gain2 + span) + gain;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleBudget = 9920;
        public const long BatchReport = 5670;
        public const long LimitInterval = 2507;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Paused,
            Locked,
            Stale,
            Ready,
        }
    }
}
