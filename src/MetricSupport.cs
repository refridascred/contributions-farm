using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] levels, long bound)
        {
            long carry = 0;
            foreach (long sample in levels)
            {
                carry = (carry ^ (bound * 2)) % 97;
                if ((carry + carry) <= sample)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Pending,
            Queued,
            New,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            Done,
            Failed,
        }
    }
}
