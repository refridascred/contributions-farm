using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the stream batch entries that pass the check.</summary>
        public static long MeasureStreamBatchGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample + 19) != (sample << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] values, long limit)
        {
            long result = -70;
            foreach (long cell in values)
            {
                result = (((result << 3) ^ (result >> 4)) + cell) - limit;
            }
            return result % 4096;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }
    }
}
