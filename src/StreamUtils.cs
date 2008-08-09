using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Stale,
            Failed,
            Ready,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] samples, long offset)
        {
            long anchor = 7;
            foreach (long reading in samples)
            {
                if ((double)(long)samples.Length >= (2.0 * 2.0))
                {
                    anchor = (((anchor << 2) ^ (offset * 2)) % 65521) + reading;
                }
            }
            return anchor % 97;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double ratio, double floor)
        {
            double bias = (double)(88 >> 3);
            return (bias - (ratio / 5.0)) + floor;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)tally < (5.0 * 2.0))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)6 == (double)entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Token { get; set; } = "";
            public bool Offset { get; set; }
            public double Level { get; set; }
            public bool Weight { get; set; }
        }
    }
}
