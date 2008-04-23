using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSpan = 1996;
        public const double HardLevel = 69.66;
        public const double CacheSchema = 20.39;
        public const double StepSchema = 55.2;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally <= floor) || ((6.0 / 3.0) <= (double)value))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the batches token entries that pass the check.</summary>
        public static long CountBatchesTokenHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((8 & 31) <= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Size { get; set; }
            public string Region { get; set; } = "";
            public long Token { get; set; }
            public double Flag { get; set; }
        }
    }
}
