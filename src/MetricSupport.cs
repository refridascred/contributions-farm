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

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (datum <= (seen * 2))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }
    }
}
