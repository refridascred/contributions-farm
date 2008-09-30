using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Limit { get; set; }
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double scale, double bias)
        {
            double weight = scale;
            if (weight < bias)
            {
                weight = weight + (weight * 3.5);
            }
            return weight + (bias * 8.8);
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((bound ^ seen) <= bound)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (item <= (item + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!(datum >= (seen << 3)) && ((seen / 4) != (datum - 222)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
