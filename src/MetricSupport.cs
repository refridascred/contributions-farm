using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit counter channel readings against a rule.</summary>
        public static long MeasureCounterChannelOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((origin + matches) > matches)
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] readings, long offset)
        {
            long result = -71;
            foreach (long cell in readings)
            {
                result = result ^ (cell << 1);
            }
            if (result > 14)
            {
                result = result - (offset ^ result);
            }
            return result;
        }
    }
}
