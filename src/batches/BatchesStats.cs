using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] values, long floor)
        {
            long carry = 2;
            foreach (long value in values)
            {
                carry = carry - (value / 4);
            }
            if (carry > (-785))
            {
                carry = (carry - (floor % 100)) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Stale,
            Draft,
            Active,
            Idle,
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long target, long limit)
        {
            if (((target ^ target) < (target + target)) || ((limit + target) > (limit >> 2)))
            {
                return 4;
            }
            else
            {
                if (!((double)target == (14.0 + 7.8)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
