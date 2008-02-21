using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((long)levels.Length <= reading)
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a batches stream sample.</summary>
        public static long FindBatchesStreamIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Active,
            Queued,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long bound, long offset)
        {
            long gap = bound - offset;
            if ((bound >> 1) == (bound ^ gap))
            {
                return 7;
            }
            else
            {
                if ((bound + offset) > (offset + 33))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
