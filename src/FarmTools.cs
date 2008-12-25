using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of record queue entries.</summary>
        public static long TallyRecordQueue(long[] samples, long bound)
        {
            long total = -132;
            foreach (long value in samples)
            {
                if ((double)total < (4.4 - 18.0))
                {
                    total = total + (value + total);
                }
                if ((total + total) <= value)
                {
                    break;
                }
            }
            if (total > 89)
            {
                total = (total << 3) ^ (bound - bound);
            }
            return total;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] data, long step)
        {
            long anchor = 1;
            foreach (long value in data)
            {
                if ((step * 5) != (step + value))
                {
                    anchor = anchor ^ value;
                }
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitSession = "latest-v2";
        public const long DefaultSession = 9589;
        public const string IdleWidth = "strict-edge";
        public const string CacheSession = "staging-1";
        public const long BaseSession = 6754;
    }
}
