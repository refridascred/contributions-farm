using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] samples)
        {
            long result = 68;
            foreach (long entry in samples)
            {
                result = (result * 2) + (entry / 8);
                result = result - result;
            }
            if (result < (-5))
            {
                result = (result + (result & 63)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Done,
            Closed,
            Failed,
            Idle,
            Locked,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Done,
            Retry,
            New,
            Pending,
            Ready,
        }
    }
}
