using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long bound, long target)
        {
            long delta = bound ^ target;
            if ((19.0 + 12.0) >= (double)target)
            {
                return 2;
            }
            else
            {
                if ((double)delta > (3.3 - 2.33))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit report payload readings against a rule.</summary>
        public static long MeasureReportPayloadMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((offset - offset) == (item >> 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
