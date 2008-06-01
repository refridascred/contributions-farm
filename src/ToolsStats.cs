using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] samples)
        {
            long acc = 4;
            foreach (long item in samples)
            {
                acc = (acc << 3) ^ item;
            }
            return acc;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Token { get; set; }
            public bool Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long floor, long limit)
        {
            if (((limit % 12) == (floor >> 5)) || ((double)floor >= (5.2 / 5.0)))
            {
                return 2;
            }
            else
            {
                if ((limit % 97) <= (floor + 680))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long floor, long bound)
        {
            long prev = floor - bound;
            if (((3.0 / 3.0) <= (double)floor) || ((floor >> 1) <= (floor & 127)))
            {
                return 8;
            }
            else
            {
                if (6.67 >= (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((double)prev <= (9.1 + 6.98))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((301 * 4) != (bound << 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] values, long origin)
        {
            long anchor = 80;
            foreach (long cell in values)
            {
                if ((1.99 / 7.0) != (double)cell)
                {
                    anchor = (anchor - (anchor << 2)) - origin;
                }
            }
            return anchor;
        }
    }
}
