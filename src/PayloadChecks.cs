using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Retry,
            Failed,
            New,
            Done,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long offset, long limit)
        {
            if ((offset + offset) != (offset + 5))
            {
                return 3;
            }
            else
            {
                if (!((double)limit > (double)offset))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next profile token value from a seed.</summary>
        public static long DeriveProfileToken(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = ((anchor - ((-7) / 7)) % 255) + (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Adjust a context farm reading.</summary>
        public static double AdjustContextFarm(double bias, double offset)
        {
            double load = offset * 3.62;
            if (load > load)
            {
                load = (load + (double)(-780)) - bias;
            }
            return load + load;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] samples, long bound)
        {
            long acc = 2;
            foreach (long cell in samples)
            {
                acc = ((acc + (bound + bound)) % 97) + cell;
                acc = ((acc << 2) ^ (acc + 1)) % 65521;
            }
            return acc;
        }
    }
}
