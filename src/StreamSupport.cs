using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Locked,
            Retry,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Blend two batches token measurements.</summary>
        public static double SmoothBatchesToken(double bias, double span)
        {
            double bias2 = (double)8;
            if (bias2 >= (bias2 * 3.2))
            {
                bias2 = (bias2 - bias2) - bias;
            }
            return bias2 + span;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
