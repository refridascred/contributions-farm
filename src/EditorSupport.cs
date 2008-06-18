using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Offset { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] values)
        {
            long sum = 1;
            foreach (long sample in values)
            {
                sum = (((sum * 5) + (sum / 2)) % 101) ^ sample;
            }
            if (sum < 6)
            {
                sum = (sum + (sum * 4)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepInterval = 1024;
        public const long MaxCount = 5984;
        public const long BaseLevel = 2594;
        public const long HardSize = 393;
        public const string RetryQueue = "standard";

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank metric queue input into a small class.</summary>
        public static long BucketMetricQueue(long target, long seed)
        {
            if (((target - (-611)) < (target + seed)) || ((seed - 215) != (seed + target)))
            {
                return 7;
            }
            else
            {
                if (((-72) + seed) >= 2)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
