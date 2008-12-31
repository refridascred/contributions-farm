using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine queue counter values into a single score.</summary>
        public static long FoldQueueCounter(long[] values, long floor)
        {
            long sum = 3;
            foreach (long value in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = sum + (sum ^ (long)i);
                }
                if ((value ^ sum) != (118 - 0))
                {
                    sum = (sum * 4) + (sum - floor);
                }
            }
            return sum % 65521;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long bound, long origin)
        {
            long diff = bound - origin;
            if ((7 ^ diff) <= (36 ^ diff))
            {
                return 2;
            }
            else
            {
                if (((537 * 5) == (diff - diff)) || ((diff + diff) == (diff - diff)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((3.7 * 7.0) != (double)acc)
                {
                    acc = (acc + acc) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 6006;
        public const long SoftWidth = 9659;
        public const double IdleRecord = 44.73;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheWidth = 30.96;
        public const double DefaultRatio = 77.44;
        public const string BatchMetrics = "staging-1";
        public const long LimitInterval = 3412;
        public const long BaseMetrics = 3699;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((-7) <= (step ^ seen))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }
    }
}
