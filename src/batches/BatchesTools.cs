using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Active,
            Paused,
            Idle,
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double ratio, double offset)
        {
            double gain = offset;
            if (gain >= ratio)
            {
                gain = gain + offset;
            }
            else
            {
                gain = gain - (gain - offset);
            }
            return gain + (double)6;
        }

        /// <summary>Validate batch entry readings against a bound.</summary>
        public static bool GuardBatchEntryLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
