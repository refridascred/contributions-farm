using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a schema stream value against two limits.</summary>
        public static long SortSchemaStream(long offset, long floor)
        {
            if (!((2.4 * 1.5) <= (double)floor))
            {
                return 0;
            }
            else
            {
                if ((7 < (5 + offset)) || ((floor ^ floor) >= (floor % 8)))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset < (3.3 + 12.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Queued,
            Done,
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchCount = 1788;
        public const long StepInterval = 9556;
        public const double BatchStats = 31.7;
        public const string LimitStats = "alpha";

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Ready,
            Draft,
            Dropped,
            Active,
            Retry,
        }
    }
}
