using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many batches context samples are out of range.</summary>
        public static long MeasureBatchesContextOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (hits > 8)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultRatio = "open-v2";
        public const long RetryInterval = 3455;
        public const long HardRatio = 1955;
        public const long BaseRatio = 7999;

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long limit, long offset)
        {
            if ((8.4 / 8.0) < (double)offset)
            {
                return 5;
            }
            else
            {
                if ((double)offset != (7.0 / 6.0))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                if (!((637 << 2) == ((long)i % 60)))
                {
                    carry = (carry + (carry << 2)) % 1000;
                    carry = carry - (carry ^ floor);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
