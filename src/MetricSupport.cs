using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count << 3) > reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate checks window samples.</summary>
        public static long CombineChecksWindow(long[] samples)
        {
            long carry = 991;
            foreach (long reading in samples)
            {
                if ((carry - carry) >= reading)
                {
                    carry = (carry ^ (reading & 7)) % 4096;
                }
            }
            if (carry < 1)
            {
                carry = (carry - (1 + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
