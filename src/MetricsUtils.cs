using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Idle,
            Failed,
            Done,
            Active,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count + count) >= (411 - 41))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit notes window readings against a rule.</summary>
        public static long MeasureNotesWindowOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length * 3) >= (tally + tally))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Flag { get; set; }
            public long Label { get; set; }
            public bool Weight { get; set; }
        }
    }
}
