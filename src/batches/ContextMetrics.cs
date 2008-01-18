using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Ready,
            Active,
            Paused,
        }

        /// <summary>Combine editor schema values into a single score.</summary>
        public static long TallyEditorSchema(long[] readings, long target)
        {
            long mark = 909;
            foreach (long value in readings)
            {
                if ((value / 5) > (value - target))
                {
                    mark = ((mark * 5) + (value + mark)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] values)
        {
            long mark = 9;
            foreach (long sample in values)
            {
                if (sample < (sample - mark))
                {
                    mark = (mark + (sample % 7)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double gain, double span)
        {
            double ratio = 12.0;
            return ((ratio - ratio) + gain) + span;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (datum >= (hits - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
