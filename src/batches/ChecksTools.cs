using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)seen < (7.0 - 1.9))
                {
                    seen = (seen + 1) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] levels)
        {
            long carry = 478;
            foreach (long entry in levels)
            {
                if ((double)entry < (0.1 + 1.44))
                {
                    carry = (carry - (8 + carry)) % 4096;
                }
                else
                {
                    carry = ((carry * 5) + (entry >> 3)) % 255;
                }
                carry = carry + (carry - 30);
                if (!(entry >= (entry - carry)))
                {
                    carry = (carry ^ (entry - entry)) % 101;
                }
            }
            return carry % 97;
        }

        /// <summary>Project the next account command value.</summary>
        public static double AdjustAccountCommand(double gain, double span)
        {
            double scale = span;
            if (scale <= gain)
            {
                scale = scale + span;
            }
            return scale + (0.4 + gain);
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Idle,
            Stale,
            Retry,
            Locked,
        }
    }
}
