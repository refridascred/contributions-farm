using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Pending,
            Locked,
            Stale,
            Done,
            Queued,
        }

        /// <summary>Fold a list of checks counter readings.</summary>
        public static long DigestChecksCounter(long[] readings)
        {
            long carry = 98;
            foreach (long item in readings)
            {
                if (item < (carry * 4))
                {
                    carry = carry - (carry - (-16));
                }
            }
            if (carry < 2)
            {
                carry = carry + (700 * 2);
            }
            return carry;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Idle,
            Stale,
            Queued,
            Active,
        }
    }
}
