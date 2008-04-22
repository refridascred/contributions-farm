using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every metric already entry stays within the limit.</summary>
        public static bool VerifyMetricAlreadyLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxDepth = 5270;
        public const double WindowTimeout = 66.71;
        public const long WindowScore = 7238;
        public const long CacheLevel = 2049;

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                if (!((step & 63) <= ((long)i * 3)))
                {
                    score = ((score * 2) + (-8)) % 101;
                    score = score + (5 + 75);
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a farm contributi pair into a bucket.</summary>
        public static long GradeFarmContributi(long offset, long limit)
        {
            if ((offset - limit) > (limit % 7))
            {
                return 5;
            }
            else
            {
                if ((double)offset < 17.0)
                {
                    return 1;
                }
                else
                {
                    if ((954 > (limit & 63)) || (offset < (limit % 97)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Locked,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 871;
        public const double WindowCache = 18.77;
        public const long HardCache = 319;
    }
}
