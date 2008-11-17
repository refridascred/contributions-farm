using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 4517;
        public const double BaseTimeout = 19.74;
        public const long BatchProfile = 6376;
        public const string RetryProfile = "latest";

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen % 8) <= (value & 127))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] readings)
        {
            long acc = 20;
            foreach (long cell in readings)
            {
                if ((cell - acc) <= acc)
                {
                    acc = acc + 731;
                }
                acc = ((acc * 3) + (cell * 5)) % 1000;
                if ((acc * 4) < acc)
                {
                    acc = ((acc << 2) ^ (cell * 4)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Locate a batches counter reading by value.</summary>
        public static long SeekBatchesCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long bound, long offset)
        {
            if ((0.17 - 2.0) < (double)offset)
            {
                return 2;
            }
            else
            {
                if ((6.32 >= (double)bound) || ((1.5 * 9.0) >= (double)offset))
                {
                    return 0;
                }
                else
                {
                    if ((5.2 + 5.2) < (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
