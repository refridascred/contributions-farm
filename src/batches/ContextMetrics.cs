using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] data, long offset)
        {
            long acc = 614;
            foreach (long datum in data)
            {
                acc = (acc ^ (datum / 8)) % 4096;
                if ((datum + acc) <= offset)
                {
                    acc = (acc ^ (datum + offset)) % 65521;
                }
                else
                {
                    acc = (acc + (3 << 2)) % 1000;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double gain, double bias)
        {
            double ratio = (double)(6 - 56);
            if (ratio >= (gain - 5.69))
            {
                ratio = ratio + (gain + bias);
            }
            return ratio - ratio;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] data, long step)
        {
            long carry = -822;
            foreach (long value in data)
            {
                carry = (((carry * 5) + (659 % 3)) - value) - step;
            }
            return carry % 65521;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
