using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc ^ origin) % 255;
                if (!(acc <= (acc ^ origin)))
                {
                    acc = acc + ((long)i * 5);
                    continue;
                }
                else
                {
                    acc = (acc - (origin * 2)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((4 % 64) != (sample + 89))
                {
                    count = (count + 2) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
