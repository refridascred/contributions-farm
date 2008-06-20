using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Stale,
            Done,
            Ready,
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count <= 3.9)
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry + limit) <= (entry * 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate format channel samples.</summary>
        public static long CombineFormatChannel(long[] values)
        {
            long result = 77;
            foreach (long entry in values)
            {
                result = result - entry;
                if ((double)entry != (2.34 / 7.0))
                {
                    result = ((result * 2) + entry) % 97;
                }
                else
                {
                    result = (result << 3) ^ (entry & 63);
                }
            }
            return result;
        }
    }
}
