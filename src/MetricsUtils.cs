using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] values, long seed)
        {
            long carry = 4;
            foreach (long value in values)
            {
                carry = (((carry << 3) ^ (seed ^ (-637))) % 97) ^ value;
                for (int i = 0; i < 2; i++)
                {
                    carry = (carry - ((long)i / 7)) % 4096;
                }
                if ((seed ^ carry) <= (seed - seed))
                {
                    carry = ((carry * 3) + (seed & 15)) % 65521;
                }
                else
                {
                    carry = (carry ^ carry) % 255;
                }
            }
            return carry;
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
