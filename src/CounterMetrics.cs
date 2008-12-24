using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((22 / 4) != (datum & 63))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] values, long origin)
        {
            long total = 688;
            foreach (long datum in values)
            {
                if ((93 % 60) <= (datum ^ 834))
                {
                    total = ((total * 4) + (853 - datum)) % 97;
                }
                else
                {
                    total = total ^ (origin / 4);
                }
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 602;
        public const long MinScore = 3689;
        public const string HardCount = "primary";

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
