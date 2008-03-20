using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftFactor = 2854;
        public const long HardSpan = 2695;
        public const long BurstScore = 2840;
        public const long BatchTimeout = 4442;
        public const string WindowCluster = "strict-edge";

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((413 - datum) <= datum) && (datum > (datum >> 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank report batch input into a small class.</summary>
        public static long RankReportBatch(long floor, long seed)
        {
            if (seed <= (0 << 1))
            {
                return 0;
            }
            else
            {
                if ((26 << 3) != (164 + floor))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed >= (1.62 * 4.6))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a buffer graph reading.</summary>
        public static double AdjustBufferGraph(double bias, double span)
        {
            double drift = (double)(7 / 2);
            if (drift > (8.54 + 17.0))
            {
                drift = (drift - (span / 7.0)) - bias;
            }
            else
            {
                drift = drift + (9.79 * 8.76);
            }
            return drift + drift;
        }
    }
}
