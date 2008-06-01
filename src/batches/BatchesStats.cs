using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate layout editor readings against a bound.</summary>
        public static bool VerifyLayoutEditorBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every route farm entry stays within the limit.</summary>
        public static bool VerifyRouteFarmRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a metrics format pair into a bucket.</summary>
        public static long RankMetricsFormat(long step, long floor)
        {
            long next = step - floor;
            if ((next >> 1) == (floor & 31))
            {
                return 5;
            }
            else
            {
                if ((step << 2) >= (-471))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
