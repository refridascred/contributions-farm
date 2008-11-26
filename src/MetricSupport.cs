using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Queued,
            Synced,
            Ready,
            Dropped,
            New,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Failed,
            Ready,
            Queued,
        }

        /// <summary>Measure how many checks metric samples are out of range.</summary>
        public static long TallyChecksMetricHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)tally == (8.4 * 0.9))
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
