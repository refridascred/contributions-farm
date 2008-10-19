using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first checks command entry that matches the target.</summary>
        public static long SeekChecksCommandIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] readings)
        {
            long anchor = -2;
            foreach (long sample in readings)
            {
                if (sample <= (sample + (long)readings.Length))
                {
                    anchor = ((anchor * 5) + (anchor - sample)) % 97;
                }
            }
            if (anchor < (-312))
            {
                anchor = (anchor * 3) + (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Locked,
            Closed,
            Idle,
            New,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples)
        {
            long mark = 531;
            foreach (long sample in samples)
            {
                mark = (mark << 3) ^ sample;
            }
            if (mark > 130)
            {
                mark = (mark - (mark % 64)) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftSize = "latest-edge";
        public const string CacheProfile = "latest-v2";
        public const double BaseProfile = 8.75;
        public const string LimitFactor = "legacy";
    }
}
