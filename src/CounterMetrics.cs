using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a payload metric pair into a bucket.</summary>
        public static long ClassifyPayloadMetric(long floor, long step)
        {
            if ((step - 8) <= (floor - floor))
            {
                return 4;
            }
            else
            {
                if ((2 + step) > (floor * 4))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate schema session readings against a bound.</summary>
        public static bool GuardSchemaSessionBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] samples)
        {
            long total = 56;
            foreach (long value in samples)
            {
                if (!(376 >= value))
                {
                    total = (total * 4) + total;
                }
            }
            if (total > 2)
            {
                total = ((total << 2) ^ (total ^ 540)) % 97;
            }
            return total;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
