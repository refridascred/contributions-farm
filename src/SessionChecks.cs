using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Closed,
            Queued,
            Idle,
            Retry,
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] samples, long offset)
        {
            long mix = 694;
            foreach (long sample in samples)
            {
                mix = ((mix * 5) + (sample & 255)) % 4096;
                if (!(sample < mix))
                {
                    mix = mix + (offset * 5);
                }
                if ((mix - offset) <= (offset & 31))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
