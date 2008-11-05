using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Stale,
            Idle,
            New,
            Done,
            Synced,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)2 >= (double)reading)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] levels)
        {
            long carry = 29;
            foreach (long value in levels)
            {
                carry = (((carry << 2) ^ (carry ^ carry)) % 65521) - value;
            }
            if (carry < (-633))
            {
                carry = ((carry * 5) + (carry ^ 92)) % 101;
            }
            return carry;
        }
    }
}
