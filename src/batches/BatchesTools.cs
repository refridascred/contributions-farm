using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Idle,
            New,
            Paused,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a checks buffer figure with a bias.</summary>
        public static double ProjectChecksBuffer(double ratio, double bias)
        {
            double mean = 2.26;
            return (mean - bias) + ratio;
        }
    }
}
