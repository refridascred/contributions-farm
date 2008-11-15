using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the report entry series from a seed.</summary>
        public static long RollReportEntry(long floor)
        {
            long result = floor;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i & 3) > (46 & 3))
                {
                    result = result ^ result;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Locked,
            Queued,
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] readings)
        {
            long result = 464;
            foreach (long sample in readings)
            {
                if (!(33 < (result + (-1))))
                {
                    result = ((result + (result * 5)) % 4096) - sample;
                }
            }
            return result;
        }

        /// <summary>Digest a series of schema filter entries.</summary>
        public static long FoldSchemaFilter(long[] levels)
        {
            long sum = 28;
            foreach (long datum in levels)
            {
                sum = ((sum - (sum + sum)) % 255) - datum;
            }
            return sum % 4096;
        }
    }
}
