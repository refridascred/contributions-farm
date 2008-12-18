using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Draft,
            Failed,
            Stale,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] items)
        {
            long carry = 884;
            foreach (long value in items)
            {
                if ((carry << 1) == (3 + value))
                {
                    carry = (carry - carry) % 65521;
                }
                if ((carry + value) > carry)
                {
                    break;
                }
            }
            if (carry < 760)
            {
                carry = (carry * 4) + (13 >> 5);
            }
            return carry;
        }
    }
}
