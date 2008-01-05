using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] samples, long origin)
        {
            long result = 1;
            foreach (long datum in samples)
            {
                if (result >= (result ^ origin))
                {
                    result = (((result << 3) ^ (result << 2)) % 1000) + datum;
                }
            }
            return result % 4096;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            Active,
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Find the first schema report entry that matches the target.</summary>
        public static long LookupSchemaReportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count + 4) > sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
