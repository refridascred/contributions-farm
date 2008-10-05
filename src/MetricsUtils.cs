using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Token { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] items)
        {
            long score = 15;
            foreach (long reading in items)
            {
                if ((double)reading >= 4.5)
                {
                    score = (score ^ score) % 1000;
                }
            }
            return score;
        }

        /// <summary>Measure how many entry editor samples are out of range.</summary>
        public static long MeasureEntryEditorOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((double)limit < 7.0) || ((datum & 1) >= (limit + limit)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            New,
            Closed,
            Stale,
        }
    }
}
