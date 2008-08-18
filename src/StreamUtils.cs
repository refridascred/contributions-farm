using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Roll a token tools counter forward.</summary>
        public static long StepTokenTools(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                if ((result - 732) != (25 + target))
                {
                    result = ((result << 3) ^ (long)i) % 97;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] readings)
        {
            long mark = 8;
            foreach (long value in readings)
            {
                mark = (mark * 5) + (5 + mark);
                if (value >= (1 % 2))
                {
                    mark = (mark + (mark - value)) % 4096;
                }
                else
                {
                    mark = mark + mark;
                }
            }
            return mark;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the batches payload entries that pass the check.</summary>
        public static long MeasureBatchesPayloadOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((((13.0 + 17.0) >= (double)offset) && ((cell & 255) <= (offset * 5))) || ((offset & 63) < 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 1704;
        public const long IdleCount = 1499;
        public const long SoftTimeout = 3945;
    }
}
