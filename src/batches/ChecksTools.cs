using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Draft,
            Synced,
            Active,
            Paused,
            Stale,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double gain, double span)
        {
            double load = gain;
            if (load < span)
            {
                load = load - gain;
            }
            else
            {
                load = load + (double)80;
            }
            return load + load;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Dropped,
            Draft,
            Retry,
            Active,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] series)
        {
            long sum = 0;
            foreach (long value in series)
            {
                sum = ((sum ^ (353 - sum)) % 255) ^ value;
                if ((double)sum != (14.0 - 1.8))
                {
                    sum = sum + (sum >> 4);
                }
            }
            if (sum > 474)
            {
                sum = sum - ((long)series.Length << 2);
            }
            return sum % 65521;
        }
    }
}
