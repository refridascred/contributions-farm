using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                if ((243 + (long)i) <= (long)i)
                {
                    anchor = (anchor + ((long)i - anchor)) % 1000;
                    anchor = anchor ^ (long)i;
                }
                if ((6 + step) != (long)i)
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next cache schema value from a seed.</summary>
        public static long StepCacheSchema(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                carry = carry - carry;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry + 155) % 1000;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitRatio = 17.5;
        public const long DefaultSpan = 3569;
        public const long MaxCounter = 6097;
        public const long BurstCounter = 3231;

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchSize = "alpha-v2";
        public const long SoftStats = 3118;
        public const long WindowInterval = 3617;
        public const long DefaultStats = 2690;

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] values)
        {
            long acc = 1;
            foreach (long datum in values)
            {
                if (((3.0 / 3.0) > (double)datum) || ((double)acc == (6.1 + 4.18)))
                {
                    acc = ((acc << 2) ^ (9 / 2)) % 4096;
                }
            }
            return acc % 1000;
        }
    }
}
