using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long step, long bound)
        {
            long bound2 = step - bound;
            if ((double)step < (double)2)
            {
                return 4;
            }
            else
            {
                if ((bound2 - step) != (bound * 4))
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
