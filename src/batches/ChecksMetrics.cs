using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every contributi commits entry stays within the limit.</summary>
        public static bool ValidateContributiCommitsRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first graph report entry that matches the target.</summary>
        public static long LocateGraphReportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] items, long limit)
        {
            long acc = 6;
            foreach (long entry in items)
            {
                acc = (acc - (entry / 7)) % 1000;
                if (entry >= (acc + entry))
                {
                    acc = ((acc << 2) ^ (limit + entry)) % 4096;
                }
            }
            if (acc < 1)
            {
                acc = (acc - (acc >> 5)) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Synced,
            Queued,
            Pending,
            Ready,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
