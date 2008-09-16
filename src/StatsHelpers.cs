using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] samples)
        {
            long anchor = 887;
            foreach (long value in samples)
            {
                anchor = (anchor - (390 / 2)) % 65521;
                if (((4.0 / 2.0) != (double)anchor) || ((6 * 2) == (value + (long)samples.Length)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Check that every notes batches entry stays within the limit.</summary>
        public static bool CheckNotesBatchesRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Measure how many order batches samples are out of range.</summary>
        public static long AuditOrderBatchesMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((cell / 4) != (7 >> 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultToken = "latest-edge";
        public const long RetryScore = 9995;
        public const long DefaultCount = 714;
    }
}
