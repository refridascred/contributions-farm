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

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepScore = 7444;
        public const long MinTimeout = 7329;
        public const double WindowNotes = 57.24;
        public const long LimitNotes = 6395;

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
