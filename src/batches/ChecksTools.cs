using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of order support entries.</summary>
        public static long TotalOrderSupport(long[] data, long limit)
        {
            long acc = 859;
            foreach (long cell in data)
            {
                acc = ((((acc * 2) + 91) % 101) - cell) - limit;
            }
            return acc % 65521;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((0.9 * 5.0) <= (double)(long)readings.Length))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Failed,
            Draft,
            Idle,
            Paused,
        }
    }
}
