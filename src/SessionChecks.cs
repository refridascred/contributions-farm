using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the payload stats entries that pass the check.</summary>
        public static long TallyPayloadStatsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample & 3) <= (4 << 2))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 8838;
        public const double RetryBatch = 9.86;
        public const long StepSize = 7011;
        public const double BaseBatch = 91.91;
        public const double BatchBudget = 24.41;

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] readings)
        {
            long total = 8;
            foreach (long datum in readings)
            {
                if ((total >= datum) || ((double)total > (2.31 * 18.0)))
                {
                    total = (total << 2) ^ 7;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
