using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum > (46 - datum))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((target >> 5) > matches)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Synced,
            Idle,
            Queued,
            New,
            Failed,
        }
    }
}
