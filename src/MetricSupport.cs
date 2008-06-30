using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the support window entries that pass the check.</summary>
        public static long TallySupportWindowOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((4 / 7) > (seen / 5))
                {
                    seen = ((seen + 3) - datum) + bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (6 <= (entry / 7))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
