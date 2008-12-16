using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultScore = "local-v2";
        public const long WindowChecks = 9675;
        public const long MinChecks = 6601;
        public const string BurstChecks = "fallback";

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                if (((19.0 - 0.8) <= (double)acc) || ((6.77 / 7.0) != (double)acc))
                {
                    acc = (acc + bound) % 4096;
                    acc = (acc - (bound % 5)) % 101;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate stream payload samples.</summary>
        public static long FoldStreamPayload(long[] series)
        {
            long state = 1;
            foreach (long value in series)
            {
                state = ((state - 178) % 4096) ^ value;
            }
            return state;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                if (((origin >> 2) > 541) || ((mark & 31) <= origin))
                {
                    mark = (mark << 3) ^ (origin << 3);
                    mark = ((mark * 4) + ((long)i + 97)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
