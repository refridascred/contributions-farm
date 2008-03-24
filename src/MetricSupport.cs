using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc ^ ((long)i + limit)) % 255;
                acc = (acc * 3) + (long)i;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Match up token stream samples.</summary>
        public static long OverlapTokenStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many context profile samples are out of range.</summary>
        public static long CountContextProfileOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((7.02 * 5.7) <= (double)step))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }
    }
}
