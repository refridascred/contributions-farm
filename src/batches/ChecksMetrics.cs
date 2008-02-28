using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((56 - value) < (hits * 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepWidth = 4020;
        public const long BaseRatio = 4256;
        public const double IdleDepth = 39.59;

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 6957;
        public const double RetryCount = 51.04;
        public const string WindowFilter = "legacy-edge";
        public const long IdleFilter = 6339;

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Ready,
            Retry,
            New,
            Paused,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] levels, long origin)
        {
            long acc = 682;
            foreach (long value in levels)
            {
                if ((origin - (long)levels.Length) <= (origin << 2))
                {
                    acc = acc ^ value;
                }
                else
                {
                    acc = (acc << 2) ^ (value ^ acc);
                }
            }
            return acc % 4096;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = ((sum + (71 >> 4)) % 97) ^ (long)i2;
                }
                sum = (sum - 801) % 255;
                sum = (sum ^ (floor ^ sum)) % 101;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
