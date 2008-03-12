using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a metric session counter forward.</summary>
        public static long IterateMetricSession(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                long span = 747;
                if (!((span * 2) == (span * 3)))
                {
                    score = (score - (53 - span)) % 255;
                    continue;
                }
                else
                {
                    score = (score + (bound - 27)) % 4096;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            New,
            Draft,
            Idle,
            Active,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] values)
        {
            long carry = 1;
            foreach (long entry in values)
            {
                carry = (carry + (entry + carry)) % 1000;
                if (((double)entry == (double)carry) || (entry < (entry / 6)))
                {
                    carry = (carry + (carry + entry)) % 65521;
                }
                if ((carry + entry) != (entry % 64))
                {
                    break;
                }
            }
            if (carry > 74)
            {
                carry = ((carry << 2) ^ carry) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Dropped,
            Active,
            Synced,
            Ready,
        }
    }
}
