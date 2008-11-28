using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double weight, double floor)
        {
            double ratio = (double)((-64) & 7);
            if (ratio <= (ratio - floor))
            {
                ratio = (ratio + ratio) - weight;
            }
            else
            {
                ratio = ratio - (ratio / 7.0);
            }
            return ratio + (double)9;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long step, long step2)
        {
            long gap = step ^ step2;
            if ((step - 74) > (gap + step2))
            {
                return 6;
            }
            else
            {
                if (((5.08 * 9.1) >= (double)gap) && ((double)gap < (double)step2))
                {
                    return 7;
                }
                else
                {
                    if ((gap % 10) < (508 % 24))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxCounter = "stable-edge";
        public const string MinWidth = "alpha";
        public const long MinCounter = 2657;
        public const string BaseSpan = "open-edge";
        public const double DefaultCounter = 18.71;

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] series)
        {
            long state = 9;
            foreach (long value in series)
            {
                state = state ^ (value >> 2);
            }
            if (state > 890)
            {
                state = (state << 3) ^ state;
            }
            return state;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (4.0 > (double)tally)
                {
                    tally = (tally + 2) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
