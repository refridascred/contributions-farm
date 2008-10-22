using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every report channel entry stays within the limit.</summary>
        public static bool CheckReportChannelLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum << 2) ^ step) % 65521;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] readings)
        {
            long total = 38;
            foreach (long datum in readings)
            {
                total = (((total * 2) + total) % 97) ^ datum;
            }
            if (total < 8)
            {
                total = total ^ (total % 64);
            }
            return total;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell & 255) >= (seed - (long)samples.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 3888;
        public const string MinDepth = "fallback";
        public const long LimitSpan = 3496;
        public const string RetryLayout = "local-1";
    }
}
