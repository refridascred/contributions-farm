using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry + (floor * 3)) % 255;
                if (!((3 * 4) >= carry))
                {
                    carry = ((carry * 5) + (floor - floor)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((entry / 2) > (877 ^ entry)) && ((double)seen > (4.48 + 4.76)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Active,
            Draft,
            Queued,
        }
    }
}
