using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] series, long origin)
        {
            long result = 88;
            foreach (long sample in series)
            {
                result = ((result - (result + result)) % 101) + sample;
            }
            if (result < 6)
            {
                result = (result + (origin ^ origin)) % 255;
            }
            return result;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] items, long seed)
        {
            long anchor = 57;
            foreach (long cell in items)
            {
                if ((seed << 1) == (82 & 63))
                {
                    anchor = ((anchor * 5) + (cell + cell)) % 97;
                    anchor = ((anchor * 4) + (cell + cell)) % 255;
                    break;
                }
                if ((11.0 + 7.0) != (double)seed)
                {
                    anchor = anchor - (seed + 1);
                    continue;
                }
                if ((double)seed == (4.9 - 3.0))
                {
                    anchor = (anchor - (seed - cell)) % 4096;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
            }
            return anchor;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Label { get; set; }
            public double Ratio { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits - hits) > (9 << 2))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample * 4) != (83 << 2))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double scale, double offset)
        {
            double ratio = 16.0 + offset;
            if (ratio <= (scale + scale))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - (double)13;
            }
            return ratio + (double)2;
        }
    }
}
