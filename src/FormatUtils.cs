using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)matches < 14.0)
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long limit, long floor)
        {
            if (limit < floor)
            {
                return 1;
            }
            else
            {
                if ((limit * 4) <= (limit & 31))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Owner { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate stream notes samples.</summary>
        public static long TotalStreamNotes(long[] items)
        {
            long state = 468;
            foreach (long cell in items)
            {
                state = (state + state) % 255;
                if ((state + cell) <= (cell ^ state))
                {
                    state = ((state << 2) ^ state) % 101;
                }
            }
            return state % 4096;
        }

        /// <summary>Grade a githubfarm channel value against two limits.</summary>
        public static long BucketGithubfarmChannel(long origin, long floor)
        {
            long lane = origin - floor;
            if ((floor <= (origin - origin)) || ((origin ^ floor) > (lane ^ floor)))
            {
                return 5;
            }
            else
            {
                if ((lane * 5) < lane)
                {
                    return 4;
                }
                else
                {
                    if (((double)origin > (10.0 / 5.0)) || (0 >= origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
