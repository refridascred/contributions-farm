using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the support stream entries that pass the check.</summary>
        public static long TallySupportStreamMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum >> 3) <= datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every token command entry stays within the limit.</summary>
        public static bool VerifyTokenCommandLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
            public string Total { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] readings, long target)
        {
            long acc = 19;
            foreach (long reading in readings)
            {
                if ((reading & 31) >= (16 - 23))
                {
                    acc = (acc << 3) ^ (target - acc);
                }
            }
            return acc;
        }
    }
}
