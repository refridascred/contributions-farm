using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] readings, long origin)
        {
            long anchor = -38;
            foreach (long cell in readings)
            {
                if (((anchor + cell) != (17 & 255)) && ((cell << 1) <= origin))
                {
                    anchor = ((anchor << 3) ^ (anchor & 15)) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Count the filter format entries that pass the check.</summary>
        public static long TallyFilterFormatOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((9.63 - 3.0) < (double)count)
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Ready,
            Closed,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!((datum >> 3) == (tally >> 5)) && ((origin - 2) != (origin / 9)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
