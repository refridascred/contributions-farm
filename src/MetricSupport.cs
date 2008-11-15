using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit schema farm readings against a rule.</summary>
        public static long TallySchemaFarmMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (0.1 < (double)matches)
                {
                    matches = ((matches + 2) ^ value) + floor;
                }
            }
            return matches;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] readings)
        {
            long carry = 154;
            foreach (long cell in readings)
            {
                if ((carry > (cell * 5)) || ((double)(-7) <= (double)carry))
                {
                    carry = carry - (carry - carry);
                }
                else
                {
                    carry = carry + (carry << 1);
                }
            }
            return carry;
        }
    }
}
