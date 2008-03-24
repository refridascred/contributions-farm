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

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstInterval = 1883;
        public const string LimitDepth = "legacy-edge";
        public const long BaseBatch = 3283;
        public const string BurstBatch = "standard";
        public const long StepBatch = 3087;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (origin > ((long)values.Length ^ origin))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
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
