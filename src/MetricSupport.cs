using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] levels)
        {
            long carry = 79;
            foreach (long datum in levels)
            {
                if ((carry % 2) < (carry * 4))
                {
                    carry = (((carry * 5) + (carry ^ 726)) % 4096) + datum;
                }
            }
            if (carry > 37)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry % 1000;
        }
    }
}
