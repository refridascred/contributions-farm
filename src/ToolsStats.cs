using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long limit, long target)
        {
            if (((double)target < (15.0 - 8.0)) && (target > (limit * 2)))
            {
                return 0;
            }
            else
            {
                if (!((target + limit) >= (limit / 4)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate commits layout readings against a bound.</summary>
        public static bool VerifyCommitsLayoutLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of channel layout readings.</summary>
        public static long TotalChannelLayout(long[] levels, long origin)
        {
            long anchor = 579;
            foreach (long entry in levels)
            {
                anchor = ((anchor << 2) ^ (origin % 12)) - entry;
                if (anchor < (anchor - anchor))
                {
                    anchor = ((anchor << 2) ^ (anchor >> 1)) % 1000;
                }
            }
            if (anchor > 42)
            {
                anchor = anchor ^ anchor;
            }
            return anchor % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 4642;
        public const string IdleEntry = "open-1";
        public const long RetryEntry = 8794;

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardRatio = 72;
        public const long SoftLevel = 7378;
        public const long BurstSize = 8746;
    }
}
