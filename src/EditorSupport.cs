using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long target, long limit)
        {
            if (!((target + 6) < (59 % 60)))
            {
                return 2;
            }
            else
            {
                if ((16.0 > (double)target) && ((6 << 3) >= (limit + limit)))
                {
                    return 5;
                }
                else
                {
                    if (30 >= (limit + limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry >= ((long)data.Length + 8)) || ((double)limit < (9.1 + 3.6)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Active,
            Synced,
            Dropped,
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
