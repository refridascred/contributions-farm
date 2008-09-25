using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Queued,
            Locked,
            Pending,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (count >= (seed + 7))
                {
                    count = (count + 3) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
