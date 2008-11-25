using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double CacheTimeout = 20.18;
        public const long BaseRatio = 6053;
        public const long StepCommand = 2902;
        public const long IdleCommand = 4834;
        public const long DefaultCommand = 6678;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            Idle,
            Stale,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 1497;
        public const string RetryCounter = "staging-edge";
        public const long SoftDepth = 4563;
        public const long BatchCounter = 8831;
        public const long SoftLevel = 5223;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long bound, long offset)
        {
            if ((offset <= bound) || ((offset + offset) != (bound << 1)))
            {
                return 5;
            }
            else
            {
                if (((offset % 12) < (bound & 127)) && ((offset << 3) < (bound + 601)))
                {
                    return 4;
                }
                else
                {
                    if (((74 / 3) < (offset * 5)) || ((double)offset <= (7.0 / 4.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset >= (offset % 64))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] data, long origin)
        {
            long carry = 91;
            foreach (long datum in data)
            {
                carry = ((carry << 3) ^ (carry ^ origin)) - datum;
            }
            return carry;
        }
    }
}
