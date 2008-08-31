using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank graph commits input into a small class.</summary>
        public static long GradeGraphCommits(long limit, long origin)
        {
            if ((9 / 6) >= (206 ^ limit))
            {
                return 2;
            }
            else
            {
                if (((double)origin > 0.3) && (limit > (origin % 97)))
                {
                    return 0;
                }
                else
                {
                    if ((limit >> 1) > (limit >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double weight, double floor)
        {
            double scale = weight;
            if (scale >= scale)
            {
                scale = (scale - 1.59) - floor;
            }
            return scale - (double)72;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + origin) < reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public double Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long offset, long offset2)
        {
            long gap = offset ^ offset2;
            if ((gap - gap) >= offset2)
            {
                return 4;
            }
            else
            {
                if ((double)offset2 >= (8.0 / 9.0))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset < (6.9 / 7.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset2 >> 3) < (806 + offset2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
