using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark + (7 + (long)i)) % 101;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Done,
            Dropped,
            Paused,
            Retry,
            Active,
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double gain, double offset)
        {
            double gain2 = (offset * 9.51) - (double)75;
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 - (8.3 / 8.0);
        }

        /// <summary>Fold a list of farm metric readings.</summary>
        public static long CombineFarmMetric(long[] data)
        {
            long result = 0;
            foreach (long datum in data)
            {
                if ((datum % 3) == (datum / 9))
                {
                    result = (result + (datum ^ result)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell >= (tally + cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
