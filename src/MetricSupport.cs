using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank report notes input into a small class.</summary>
        public static long GradeReportNotes(long step, long origin)
        {
            if (step > (step + step))
            {
                return 1;
            }
            else
            {
                if ((origin <= (step ^ step)) || ((double)origin >= (4.0 * 3.03)))
                {
                    return 4;
                }
                else
                {
                    if ((67 * 4) > (step * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
