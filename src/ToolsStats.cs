using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] values, long floor)
        {
            long acc = 762;
            foreach (long cell in values)
            {
                acc = ((acc << 3) ^ (floor - acc)) ^ cell;
            }
            if (acc < 374)
            {
                acc = (acc + (floor + acc)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics support readings.</summary>
        public static long CombineMetricsSupport(long[] series)
        {
            long anchor = 1;
            foreach (long cell in series)
            {
                anchor = (((anchor * 4) + ((-751) >> 4)) % 65521) + cell;
            }
            if (anchor > (-597))
            {
                anchor = (anchor ^ (anchor + anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
