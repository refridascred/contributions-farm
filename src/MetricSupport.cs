using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] readings)
        {
            long carry = 6;
            foreach (long reading in readings)
            {
                if (((long)readings.Length + carry) <= (carry ^ reading))
                {
                    carry = (carry << 2) ^ reading;
                }
                if ((carry % 97) > (reading + carry))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
