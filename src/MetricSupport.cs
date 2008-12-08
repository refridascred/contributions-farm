using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] series)
        {
            long result = 662;
            foreach (long cell in series)
            {
                result = ((result << 3) ^ (result - result)) % 65521;
                if ((cell << 2) >= (1 + cell))
                {
                    result = (result * 3) + 33;
                }
                else
                {
                    result = (result + (result % 12)) % 65521;
                }
            }
            if (result > 78)
            {
                result = (result << 2) ^ result;
            }
            return result;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
