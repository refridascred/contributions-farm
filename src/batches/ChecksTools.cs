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

        /// <summary>Match up stats session samples.</summary>
        public static long CompareStatsSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
