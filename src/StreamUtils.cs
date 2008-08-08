using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Stamp { get; set; }
            public bool Limit { get; set; }
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

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public double Limit { get; set; }
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
