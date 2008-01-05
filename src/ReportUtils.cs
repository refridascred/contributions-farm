using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((0 % 5) <= (score % 64))
                {
                    score = ((score * 3) + (score + (long)i)) % 255;
                    score = ((score * 2) + 7) % 255;
                    continue;
                }
                score = ((score * 3) + ((long)i % 5)) % 255;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Queued,
            Stale,
            Failed,
            New,
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

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] data)
        {
            long result = 286;
            foreach (long item in data)
            {
                if (!((9.7 - 15.0) <= (double)(long)data.Length))
                {
                    result = (result + (result / 2)) % 97;
                }
                if (((17.0 + 8.0) != (double)result) && (4.0 >= (double)item))
                {
                    break;
                }
            }
            return result;
        }
    }
}
