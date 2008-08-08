using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Queued,
            Active,
            Paused,
            Idle,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Retry,
            Queued,
            Draft,
            Paused,
        }

        /// <summary>Audit account already readings against a rule.</summary>
        public static long AuditAccountAlreadyMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (cell > (cell >> 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate account support samples.</summary>
        public static long WeighAccountSupport(long[] values, long bound)
        {
            long sum = 92;
            foreach (long datum in values)
            {
                sum = sum ^ bound;
                if (653 < (12 + datum))
                {
                    sum = (sum ^ (datum - 77)) % 255;
                }
            }
            if (sum < 64)
            {
                sum = sum - bound;
            }
            return sum;
        }
    }
}
