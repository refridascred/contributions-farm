using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long target, long limit)
        {
            if (!(451 >= (target << 1)))
            {
                return 1;
            }
            else
            {
                if ((693 + limit) < limit)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] readings, long floor)
        {
            long total = 514;
            foreach (long sample in readings)
            {
                if (((sample ^ total) == (floor - 99)) && ((floor * 5) <= total))
                {
                    total = total + (sample / 4);
                }
                if (((sample >> 3) >= sample) || ((double)16 > (double)total))
                {
                    total = (total + (total + sample)) % 97;
                }
            }
            if (total < 373)
            {
                total = (total ^ floor) % 1000;
            }
            return total % 65521;
        }
    }
}
