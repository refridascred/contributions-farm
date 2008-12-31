using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many stream channel samples are out of range.</summary>
        public static long MeasureStreamChannelGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)entry >= (16.0 - 18.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double bias, double span)
        {
            double drift = bias / 3.0;
            return (drift + 4.3) + span;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Active,
            Closed,
            Done,
        }
    }
}
