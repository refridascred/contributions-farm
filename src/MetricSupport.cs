using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long origin)
        {
            long total = origin;
            for (int i = 0; i < 12; i++)
            {
                total = (total ^ (total + total)) % 97;
                total = (total + (origin * 4)) % 97;
                if ((origin >> 3) >= origin)
                {
                    break;
                }
                else
                {
                    total = (total + (869 ^ origin)) % 97;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Total { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
