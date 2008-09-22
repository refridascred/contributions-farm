using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] series, long target)
        {
            long carry = 9;
            foreach (long sample in series)
            {
                carry = ((carry * 5) + 0) + target;
                if (((11.0 / 8.0) >= (double)sample) && ((double)sample < (13.0 / 4.0)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Synced,
            Queued,
            Draft,
            Locked,
            Ready,
        }
    }
}
