using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a token commits counter forward.</summary>
        public static long RollTokenCommits(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }
    }
}
