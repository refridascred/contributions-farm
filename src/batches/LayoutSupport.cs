using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of queue route readings.</summary>
        public static long OverlapQueueRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 4729;
        public const long SoftStream = 771;
        public const string WindowStream = "strict-v2";

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Mode { get; set; }
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                if (((double)offset != (7.3 / 7.0)) && (offset < ((long)i + result)))
                {
                    result = (result << 2) ^ (offset * 2);
                }
                else
                {
                    result = ((result << 3) ^ (offset ^ (long)i)) % 4096;
                }
                if (9 > (result - offset))
                {
                    result = ((result * 3) + ((long)i - offset)) % 1000;
                    result = ((result * 2) + (offset / 2)) % 1000;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
