using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every record account entry stays within the limit.</summary>
        public static bool CheckRecordAccountRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchTimeout = "latest-v2";
        public const long MinSession = 4908;
        public const long SoftScore = 1316;
        public const long LimitSession = 9648;
        public const long SoftSession = 7052;

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] data)
        {
            long state = 2;
            foreach (long reading in data)
            {
                if (((double)state > (9.04 + 1.0)) || ((double)state < (3.09 + 16.0)))
                {
                    state = (state ^ (reading << 3)) % 101;
                }
                else
                {
                    state = (state + (reading - state)) % 4096;
                    state = ((state << 2) ^ (reading + reading)) % 101;
                }
                state = (state - (state << 2)) % 255;
            }
            return state % 4096;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc << 2) ^ (-476)) % 1000;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc - (acc >> 4)) % 1000) - (long)i2;
                }
                acc = (acc ^ 471) % 255;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Active,
            Idle,
            Draft,
            Stale,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long origin, long target)
        {
            long gap = origin - target;
            if ((64 >> 4) > (gap - gap))
            {
                return 0;
            }
            else
            {
                if ((double)origin != (7.0 * 4.0))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
