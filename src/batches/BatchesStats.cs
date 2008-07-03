using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate profile session samples.</summary>
        public static long CombineProfileSession(long[] series)
        {
            long anchor = 6;
            foreach (long value in series)
            {
                if (((7.25 + 12.0) <= (double)anchor) || ((3.35 + 19.0) <= (double)(long)series.Length))
                {
                    anchor = (((anchor << 2) ^ 43) % 1000) - value;
                }
            }
            return anchor;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Measure how many metrics already samples are out of range.</summary>
        public static long AuditMetricsAlreadyHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits % 100) < (hits / 8))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
