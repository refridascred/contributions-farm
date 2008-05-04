using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
            public double Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading << 3) <= (reading - 27))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long bound, long bound2)
        {
            if ((bound + bound2) != (bound * 2))
            {
                return 1;
            }
            else
            {
                if (((1 >> 2) != (bound2 << 2)) && ((bound2 * 2) > (bound << 2)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Locked,
            New,
            Failed,
            Idle,
            Draft,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Retry,
            Queued,
            Ready,
            New,
            Dropped,
        }
    }
}
