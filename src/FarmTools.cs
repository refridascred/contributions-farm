using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Closed,
            Failed,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] readings, long bound)
        {
            long anchor = 66;
            foreach (long datum in readings)
            {
                if ((datum / 6) >= (anchor / 6))
                {
                    anchor = anchor + (bound + bound);
                }
                else
                {
                    anchor = (anchor - (60 & 63)) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
