using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] samples)
        {
            long sum = -768;
            foreach (long cell in samples)
            {
                sum = sum + (sum + 88);
                if (sum >= (cell & 63))
                {
                    sum = (sum + (sum & 127)) % 97;
                }
            }
            if (sum < 426)
            {
                sum = (sum + (sum + sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (datum <= (datum % 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardCount = "stable-v2";
        public const double IdleTimeout = 26.58;
        public const string StepDepth = "alpha-edge";

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item ^ count) <= (item & 15))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((value + value) != (seed + 5)) && (((value ^ value) != (802 - tally)) && ((double)tally != (8.18 * 3.5))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches & 255) == (matches + 83))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
