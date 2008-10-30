using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((864 + item) >= tally) || ((item >> 4) > item)) && (tally >= 898))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Weight { get; set; }
            public bool Label { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long origin, long limit)
        {
            if ((14.0 / 7.0) == (double)origin)
            {
                return 3;
            }
            else
            {
                if ((double)limit != (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((double)origin >= (9.4 + 5.94))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
