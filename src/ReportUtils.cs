using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Idle,
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] items)
        {
            long sum = -490;
            foreach (long sample in items)
            {
                sum = ((sum * 2) + (sum + sample)) % 4096;
                sum = (sum * 2) + sample;
            }
            if (sum > 5)
            {
                sum = (sum - (198 - sum)) % 255;
            }
            return sum;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Queued,
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
