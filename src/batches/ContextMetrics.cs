using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Ready,
            Dropped,
            Failed,
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Dropped,
            Draft,
            Active,
            Queued,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long step)
        {
            long anchor = step;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor + (step % 60)) % 4096;
                if (((1.0 / 5.0) <= (double)step) || ((4.0 - 14.0) != (double)step))
                {
                    anchor = (anchor - (step ^ anchor)) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] series)
        {
            long mix = 116;
            foreach (long cell in series)
            {
                mix = (mix + cell) % 4096;
                mix = (mix << 2) ^ (cell << 2);
            }
            return mix % 65521;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((double)floor > (9.6 / 5.0)) && ((0 + floor) >= ((long)data.Length / 2)))
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }
    }
}
