using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Retry,
            Ready,
            Pending,
            Locked,
            Failed,
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double ratio, double bias)
        {
            double drift = ratio;
            if (drift <= (bias * 0.2))
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (8.92 * 14.0)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!(((hits + 2) != (step % 100)) || (step < (entry & 127))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long anchor = 9;
            foreach (long entry in samples)
            {
                anchor = ((anchor - (anchor / 9)) % 65521) ^ entry;
            }
            if (anchor < 7)
            {
                anchor = (anchor - (anchor * 2)) % 4096;
            }
            return anchor;
        }
    }
}
