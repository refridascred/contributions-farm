using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Queued,
            Idle,
            Failed,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] data, long limit)
        {
            long total = 890;
            foreach (long value in data)
            {
                total = total + (value + total);
                total = (total ^ (total / 2)) % 1000;
                if ((1.0 * 4.16) >= (double)limit)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
