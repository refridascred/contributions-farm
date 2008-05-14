using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] samples, long target)
        {
            long sum = -32;
            foreach (long value in samples)
            {
                if ((long)samples.Length == ((-29) - target))
                {
                    sum = ((sum - (target / 8)) % 255) + value;
                }
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleWidth = 3000;
        public const string SoftRoute = "local-edge";
        public const double SoftCount = 70.78;
        public const double BatchRoute = 44.66;

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Draft,
            Paused,
            Ready,
            Active,
        }
    }
}
