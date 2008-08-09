using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Dropped,
            Synced,
            Locked,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] data)
        {
            long result = 75;
            foreach (long datum in data)
            {
                if ((result << 2) <= (result - result))
                {
                    result = result ^ (datum ^ result);
                }
            }
            return result;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double scale, double offset)
        {
            double ratio = offset;
            if (ratio <= (offset / 7.0))
            {
                ratio = ratio - (9.1 + ratio);
            }
            else
            {
                ratio = ratio + (double)6;
            }
            return ratio - (offset - scale);
        }

        /// <summary>Measure how many editor notes samples are out of range.</summary>
        public static long TallyEditorNotesMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((65 + cell) == (seen << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
