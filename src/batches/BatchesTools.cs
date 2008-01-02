using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((-53) / 6) > (value >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 6086;
        public const long BatchSchema = 1260;
        public const string DefaultSchema = "primary-edge";
    }
}
