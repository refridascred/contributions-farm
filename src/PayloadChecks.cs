using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark ^ (mark / 3)) % 1000;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                mark = mark ^ mark;
                mark = (mark * 3) + ((long)i >> 1);
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark << 2) ^ (bound ^ bound)) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the support payload series from a seed.</summary>
        public static long RollSupportPayload(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheEntry = 9.72;
        public const string SoftInterval = "legacy-1";
        public const long BurstEntry = 5207;

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultDepth = "latest";
        public const long WindowRecord = 7565;
        public const double LimitRecord = 80.75;
    }
}
