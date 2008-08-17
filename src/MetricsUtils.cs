using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (reading < (reading - bound))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Stamp { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
