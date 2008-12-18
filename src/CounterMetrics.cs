using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long limit, long origin)
        {
            long span = limit + origin;
            if ((2.2 / 6.0) < (double)limit)
            {
                return 3;
            }
            else
            {
                if ((span <= (origin ^ span)) && ((origin >> 3) < (span << 3)))
                {
                    return 2;
                }
                else
                {
                    if (893 < (origin % 100))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a batch buffer pair into a bucket.</summary>
        public static long ClassifyBatchBuffer(long step, long step2)
        {
            if ((step >> 4) < (step & 3))
            {
                return 8;
            }
            else
            {
                if ((step > (91 + 90)) && (867 > (step2 + step)))
                {
                    return 0;
                }
                else
                {
                    if ((5.0 <= (double)step2) || ((double)step2 <= 4.41))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 8454;
        public const long SoftFactor = 4041;
        public const string IdleStream = "latest-1";

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((cell ^ (long)values.Length) >= (cell + matches)) && (((long)values.Length + 5) <= (cell + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
