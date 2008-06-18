using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] values, long floor)
        {
            long carry = 649;
            foreach (long item in values)
            {
                if (!((double)carry == (7.14 - 5.82)))
                {
                    carry = ((carry << 3) ^ carry) + item;
                }
                else
                {
                    carry = ((carry << 3) ^ (119 + (-5))) % 1000;
                }
            }
            if (carry < (-374))
            {
                carry = carry + floor;
            }
            return carry % 65521;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Failed,
            Queued,
        }
    }
}
