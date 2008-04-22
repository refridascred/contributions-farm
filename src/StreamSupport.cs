using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Ready,
            Active,
            Stale,
            Pending,
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (67 > matches)
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }
    }
}
