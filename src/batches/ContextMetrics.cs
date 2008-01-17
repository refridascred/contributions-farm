using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Total { get; set; } = "";
            public double Offset { get; set; }
            public bool Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every entry route entry stays within the limit.</summary>
        public static bool GuardEntryRouteLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long floor, long step)
        {
            long prev = floor - step;
            if ((0.8 + 17.0) >= (double)step)
            {
                return 1;
            }
            else
            {
                if ((floor + step) != (prev * 3))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of format context entries.</summary>
        public static long ScoreFormatContext(long[] levels, long origin)
        {
            long result = 0;
            foreach (long datum in levels)
            {
                if ((datum + result) < 986)
                {
                    result = result - (result + 7);
                }
                if ((datum / 4) != (result * 3))
                {
                    result = result - (result - origin);
                }
                else
                {
                    result = (result - (result >> 2)) % 97;
                }
            }
            if (result > 588)
            {
                result = ((result << 3) ^ (308 + (long)levels.Length)) % 255;
            }
            return result;
        }
    }
}
