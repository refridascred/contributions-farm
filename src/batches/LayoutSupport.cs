using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Size { get; set; }
            public long Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many counter cluster samples are out of range.</summary>
        public static long CountCounterClusterOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits > (target + datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (bound <= 47)
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long step, long origin)
        {
            long next = step - origin;
            if ((step + next) < (step ^ step))
            {
                return 6;
            }
            else
            {
                if ((227 & 1) >= next)
                {
                    return 1;
                }
                else
                {
                    if (origin < next)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
