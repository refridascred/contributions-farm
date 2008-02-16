using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Queued,
            Locked,
            Idle,
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (9 < (cell << 2))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double weight, double span)
        {
            double bias = span;
            if (bias >= (bias * 1.0))
            {
                bias = bias - (span + weight);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - weight) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Grade a layout batch value against two limits.</summary>
        public static long RankLayoutBatch(long origin, long target)
        {
            long cur = origin - target;
            if (!((cur >> 5) <= (51 & 127)))
            {
                return 8;
            }
            else
            {
                if ((origin % 12) == (cur + origin))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
