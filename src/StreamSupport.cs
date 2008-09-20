using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a route record reading.</summary>
        public static double BlendRouteRecord(double rate, double span)
        {
            double mean = rate;
            if (mean > (span + rate))
            {
                mean = mean - span;
            }
            return mean - mean;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Offset { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Check that every token entry entry stays within the limit.</summary>
        public static bool CheckTokenEntryLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
