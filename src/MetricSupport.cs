using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of report route readings.</summary>
        public static long FoldReportRoute(long[] values)
        {
            long acc = 2;
            foreach (long entry in values)
            {
                acc = ((acc ^ (74 << 2)) % 4096) - entry;
                if (acc < (39 + acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Rank report batches input into a small class.</summary>
        public static long ClassifyReportBatches(long step, long origin)
        {
            long bound = step - origin;
            if (((double)origin < (3.19 + 13.0)) && ((step << 1) < 31))
            {
                return 0;
            }
            else
            {
                if ((bound + 0) > step)
                {
                    return 7;
                }
                else
                {
                    if (((bound + 81) > (bound % 60)) || ((step >> 4) == (step / 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Closed,
            Idle,
            Failed,
            Paused,
        }
    }
}
