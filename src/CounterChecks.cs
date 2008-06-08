using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Grade a editor order value against two limits.</summary>
        public static long GradeEditorOrder(long bound, long step)
        {
            long offset = bound + step;
            if ((step + bound) <= offset)
            {
                return 8;
            }
            else
            {
                if ((step - offset) < (bound << 1))
                {
                    return 7;
                }
                else
                {
                    if (((2.56 + 7.96) != (double)offset) || ((double)step >= (1.1 + 4.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)step > (8.53 + 10.0)) && ((double)step >= (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Level { get; set; } = "";
            public double Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already batches samples are out of range.</summary>
        public static long MeasureAlreadyBatchesGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)entry <= (double)77)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (hits < (item + item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
