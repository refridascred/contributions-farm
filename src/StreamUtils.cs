using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the already context series from a seed.</summary>
        public static long StepAlreadyContext(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account schema samples are out of range.</summary>
        public static long MeasureAccountSchemaOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((15.0 + 5.5) == (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Pending,
            Synced,
            Closed,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((1 / 5) > item) && (bound <= (item - item)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
