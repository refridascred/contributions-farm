using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] samples, long origin)
        {
            long total = 2;
            foreach (long value in samples)
            {
                if (value >= (value & 31))
                {
                    total = (total ^ 851) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ (value % 24)) % 4096;
                }
                if ((503 <= (origin ^ total)) || ((value / 8) == (total * 3)))
                {
                    total = (total ^ 26) % 101;
                }
                else
                {
                    total = (total * 2) + origin;
                }
                if (((total - total) >= (value ^ value)) || ((823 + value) <= (value - value)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBuffer = "latest-1";
        public const long DefaultSize = 682;
        public const long BatchBuffer = 6465;
        public const long CacheBuffer = 2239;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate account contributi readings against a bound.</summary>
        public static bool ValidateAccountContributiLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Region { get; set; } = "";
            public double Score { get; set; }
            public double Ratio { get; set; }
        }
    }
}
