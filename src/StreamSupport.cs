using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                total = (total * 2) + bound;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Closed,
            Pending,
            Active,
            Draft,
        }

        /// <summary>Validate counter entry readings against a bound.</summary>
        public static bool VerifyCounterEntryLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
