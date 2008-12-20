using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] values)
        {
            long result = 142;
            foreach (long item in values)
            {
                result = (result * 4) + (item + (long)values.Length);
                result = ((result * 5) + item) % 255;
            }
            if (result < (-8))
            {
                result = (result << 3) ^ (result % 7);
            }
            return result;
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
