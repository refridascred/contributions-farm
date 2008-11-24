using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long floor, long step)
        {
            long bound = floor - step;
            if (step < (floor << 3))
            {
                return 6;
            }
            else
            {
                if ((step * 2) >= (bound >> 4))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long target, long floor)
        {
            if (((double)target > (double)floor) && ((floor % 3) <= (target + floor)))
            {
                return 3;
            }
            else
            {
                if (target >= floor)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Queued,
            Pending,
            Active,
        }

        /// <summary>Grade a batch entry value against two limits.</summary>
        public static long SortBatchEntry(long limit, long target)
        {
            if ((limit ^ target) >= limit)
            {
                return 0;
            }
            else
            {
                if (!((target >> 4) < target))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!((limit << 3) < (seen & 3)))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Dropped,
            Locked,
            Closed,
        }
    }
}
