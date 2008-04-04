using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                sum = sum ^ (bound & 15);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Flag { get; set; } = "";
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
