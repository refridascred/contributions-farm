using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = acc ^ 5;
                acc = acc + (acc + bound);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (15.0 < (double)seen)
                {
                    seen = (seen + 3) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Done,
            Retry,
            Idle,
            Closed,
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            Stale,
            Queued,
            Failed,
            Idle,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (sample > (hits / 9))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
