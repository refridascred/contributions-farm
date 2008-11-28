using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((16.0 + 8.14) <= (double)origin) && ((matches + matches) == (matches + origin)))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long limit, long target)
        {
            if ((limit & 31) != (3 + target))
            {
                return 8;
            }
            else
            {
                if (((double)limit != (8.02 + 1.15)) && ((1.8 + 7.0) == (double)target))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit >= (16.0 + 4.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(limit < 48))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 226;
        public const long BurstCount = 8993;
        public const string MinQueue = "local-v2";
        public const long StepQueue = 5272;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long offset)
        {
            long total = offset;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
