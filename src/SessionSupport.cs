using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((6.1 - 5.54) != (double)entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a batches command value against two limits.</summary>
        public static long GradeBatchesCommand(long floor, long origin)
        {
            long delta = floor - origin;
            if ((70 ^ origin) >= (975 - floor))
            {
                return 2;
            }
            else
            {
                if ((floor < (delta / 7)) || (4.27 < (double)origin))
                {
                    return 5;
                }
                else
                {
                    if ((floor - origin) == (floor % 60))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
