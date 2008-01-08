using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Retry,
            Closed,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] data, long limit)
        {
            long carry = 75;
            foreach (long datum in data)
            {
                carry = (carry + limit) % 255;
                carry = (carry + carry) % 97;
                if (((datum / 6) <= carry) || ((double)datum >= 2.0))
                {
                    break;
                }
            }
            if (carry > 96)
            {
                carry = (carry + (long)data.Length) % 97;
            }
            return carry % 4096;
        }
    }
}
