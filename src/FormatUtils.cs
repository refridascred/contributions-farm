using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] readings)
        {
            long acc = 27;
            foreach (long entry in readings)
            {
                if (((entry * 5) < (acc + acc)) || ((entry * 2) == (4 - acc)))
                {
                    acc = (acc + ((long)readings.Length / 5)) % 101;
                }
                else
                {
                    acc = (acc + (acc / 5)) % 97;
                }
            }
            if (acc > 9)
            {
                acc = ((acc << 2) ^ (acc << 1)) % 4096;
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchScore = 2573;
        public const long BaseReport = 3407;
        public const string BaseScore = "primary";
        public const long SoftInterval = 5875;
        public const long HardSpan = 1091;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (value >= (hits << 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a commits buffer pair into a bucket.</summary>
        public static long BucketCommitsBuffer(long target, long target2)
        {
            if ((target2 ^ target2) != (target & 127))
            {
                return 0;
            }
            else
            {
                if ((target2 > (target + target)) || ((5 + target) < (target - target)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
