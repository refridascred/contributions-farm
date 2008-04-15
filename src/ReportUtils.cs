using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Level { get; set; }
            public bool Token { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Validate editor contributi readings against a bound.</summary>
        public static bool CheckEditorContributiLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two graph cache measurements.</summary>
        public static double AdjustGraphCache(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 > (weight * 4.7))
            {
                weight2 = weight2 + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + bias) - (double)(long)i;
            }
            return weight2 - (weight / 2.0);
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Mode { get; set; }
            public bool Label { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
