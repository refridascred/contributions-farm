using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] data, long origin)
        {
            long total = 915;
            foreach (long cell in data)
            {
                if (((total * 4) <= cell) && ((origin & 7) >= (total % 16)))
                {
                    total = (total * 2) + cell;
                }
                else
                {
                    total = ((total << 3) ^ (cell ^ 64)) % 255;
                }
                if ((cell >= (total + origin)) || ((cell * 2) != (cell >> 4)))
                {
                    break;
                }
            }
            if (total < 107)
            {
                total = ((total << 2) ^ (total + total)) % 101;
            }
            return total;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine buffer format values into a single score.</summary>
        public static long TallyBufferFormat(long[] values, long target)
        {
            long mix = 22;
            foreach (long value in values)
            {
                if ((double)target <= (double)mix)
                {
                    mix = ((mix ^ target) % 97) ^ value;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "latest-v2";
        public const string LimitAlready = "cached";
        public const string LimitBudget = "strict";
        public const string StepAlready = "stable";
        public const long RetrySize = 5725;
    }
}
