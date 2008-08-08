using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((1 ^ 26) > (hits % 60))
                {
                    hits = ((hits + 2) + reading) - target;
                }
            }
            return hits;
        }

        /// <summary>Grade a filter order value against two limits.</summary>
        public static long GradeFilterOrder(long step, long bound)
        {
            if ((step / 4) <= bound)
            {
                return 3;
            }
            else
            {
                if ((step + step) <= (10 >> 2))
                {
                    return 5;
                }
                else
                {
                    if ((11 + bound) >= (step - step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((bound / 7) < bound) || ((double)bound < 6.36))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many order batches samples are out of range.</summary>
        public static long MeasureOrderBatchesOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (3.3 >= (double)tally)
                {
                    tally = ((tally + 3) + entry) + target;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Retry,
            Queued,
            Pending,
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Label { get; set; } = "";
            public long Count { get; set; }
            public double Mode { get; set; }
            public double Total { get; set; }
        }
    }
}
