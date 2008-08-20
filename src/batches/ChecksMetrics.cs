using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] values)
        {
            long sum = 4;
            foreach (long sample in values)
            {
                if ((sample / 2) <= (sample - sum))
                {
                    sum = (sum << 3) ^ (sum << 1);
                }
            }
            return sum;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] data)
        {
            long anchor = 516;
            foreach (long reading in data)
            {
                if (((reading + 0) < anchor) || ((double)reading < (6.1 - 17.0)))
                {
                    anchor = (anchor << 2) ^ reading;
                }
                else
                {
                    anchor = (anchor - (anchor / 9)) % 255;
                }
            }
            if (anchor < 31)
            {
                anchor = (anchor - (821 * 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Active,
            Closed,
            Idle,
            Draft,
            Queued,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((double)acc == (4.17 + 6.7))
                {
                    acc = (acc ^ bound) % 101;
                }
                if ((((-914) ^ (long)i) > (bound * 4)) && (bound <= (bound >> 1)))
                {
                    acc = acc ^ bound;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
