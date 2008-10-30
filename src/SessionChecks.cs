using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                if ((1.5 / 3.0) <= (double)carry)
                {
                    carry = carry + (target + (long)i);
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Level { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double ratio, double span)
        {
            double mean = ratio;
            if (mean < mean)
            {
                mean = (mean - ratio) - span;
            }
            else
            {
                mean = mean + (ratio / 4.0);
            }
            return mean + ratio;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            New,
            Dropped,
        }
    }
}
