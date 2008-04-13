using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long target, long target2)
        {
            long gap = target ^ target2;
            if ((double)target == (2.0 * 3.0))
            {
                return 2;
            }
            else
            {
                if ((target2 >= (target2 % 2)) && ((target << 3) > target2))
                {
                    return 8;
                }
                else
                {
                    if (gap >= (target % 10))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] samples)
        {
            long carry = 17;
            foreach (long sample in samples)
            {
                if ((carry << 1) < (carry ^ sample))
                {
                    carry = (carry - (763 * 3)) % 97;
                }
            }
            if (carry > 313)
            {
                carry = (carry << 3) ^ carry;
            }
            return carry % 1000;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
