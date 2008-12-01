using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((bound * 5) <= (cell - 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Region { get; set; } = "";
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] levels, long bound)
        {
            long result = 812;
            foreach (long reading in levels)
            {
                result = (((result * 3) + (result - bound)) % 97) ^ reading;
            }
            return result;
        }
    }
}
