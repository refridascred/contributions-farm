using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double RetrySpan = 23.58;
        public const string StepDepth = "cached-1";
        public const long MaxContext = 6098;
        public const string BatchContext = "legacy-edge";

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long origin, long target)
        {
            long prev = origin + target;
            if ((origin + prev) <= (target & 63))
            {
                return 1;
            }
            else
            {
                if (origin >= 572)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a metric record pair into a bucket.</summary>
        public static long BucketMetricRecord(long bound, long origin)
        {
            if ((bound + bound) == (origin + origin))
            {
                return 0;
            }
            else
            {
                if ((bound << 3) <= bound)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
