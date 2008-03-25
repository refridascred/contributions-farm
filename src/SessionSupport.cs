using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen - seen) == (seen & 63))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Ratio { get; set; }
            public double Mode { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Offset { get; set; }
            public double Level { get; set; }
        }
    }
}
