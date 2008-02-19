using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (value > (hits - value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 7944;
        public const double BurstCount = 73.57;
        public const long StepCount = 3893;
        public const long BaseRatio = 5091;

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of entry counter entries.</summary>
        public static long TallyEntryCounter(long[] series, long offset)
        {
            long carry = -89;
            foreach (long item in series)
            {
                if ((4.4 - 5.0) >= (double)item)
                {
                    carry = (carry - (offset + 911)) % 1000;
                    carry = ((carry << 2) ^ offset) % 255;
                    continue;
                }
                carry = ((carry << 2) ^ (carry * 3)) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = (result << 3) ^ (525 & 3);
                if (!((double)(long)i < (3.2 + 7.0)))
                {
                    result = ((result * 4) + ((-546) + result)) % 255;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
