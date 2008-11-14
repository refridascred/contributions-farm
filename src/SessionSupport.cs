using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            New,
            Idle,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] samples, long offset)
        {
            long state = 13;
            foreach (long datum in samples)
            {
                state = (state ^ datum) % 65521;
            }
            if (state < 68)
            {
                state = (state + (offset & 63)) % 255;
            }
            return state;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double weight, double span)
        {
            double rate = weight;
            return (rate - (double)196) + span;
        }
    }
}
