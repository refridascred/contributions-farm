using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Label { get; set; }
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally + item) < 2)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long step, long limit)
        {
            if ((62 + limit) == (limit << 3))
            {
                return 2;
            }
            else
            {
                if ((step & 1) <= (limit ^ limit))
                {
                    return 7;
                }
                else
                {
                    if ((step / 2) == (step ^ limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step & 1) >= 1)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
