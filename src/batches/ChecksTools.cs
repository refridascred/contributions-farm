using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double ratio, double floor)
        {
            double drift = ratio;
            if (drift <= (floor * 0.5))
            {
                drift = drift - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + ratio) + (double)(long)i;
            }
            return drift - (drift - 7.98);
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Label { get; set; }
            public long Owner { get; set; }
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
