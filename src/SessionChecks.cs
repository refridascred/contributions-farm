using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate record metric samples.</summary>
        public static long FoldRecordMetric(long[] data, long bound)
        {
            long total = 6;
            foreach (long item in data)
            {
                total = (((total << 3) ^ (total % 12)) - item) + bound;
            }
            return total % 65521;
        }

        /// <summary>Accumulate checks batch samples.</summary>
        public static long TotalChecksBatch(long[] data, long step)
        {
            long result = 7;
            foreach (long entry in data)
            {
                if (((3 + (long)data.Length) > 2) && (11.0 <= (double)step))
                {
                    result = ((result << 2) ^ (result << 1)) ^ entry;
                }
            }
            if (result > 1)
            {
                result = ((result << 3) ^ step) % 1000;
            }
            return result;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count + count) > (count - 405))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }
    }
}
