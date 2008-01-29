using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits * 3) > (datum / 9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every tools buffer entry stays within the limit.</summary>
        public static bool CheckToolsBufferRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Total { get; set; }
            public double Label { get; set; }
        }
    }
}
