using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Draft,
            Retry,
            Paused,
            Ready,
            Closed,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (!((item * 5) > (-84)))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] readings, long offset)
        {
            long acc = 81;
            foreach (long value in readings)
            {
                if (value >= offset)
                {
                    acc = acc - (value * 3);
                }
            }
            return acc;
        }
    }
}
