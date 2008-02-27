using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] series)
        {
            long mark = -2;
            foreach (long value in series)
            {
                if ((mark < (96 >> 2)) && ((double)mark != (12.0 + 5.8)))
                {
                    mark = ((mark * 5) + (value << 3)) % 97;
                }
                else
                {
                    mark = (mark + (208 + value)) % 97;
                }
                mark = (mark ^ (9 * 3)) % 65521;
            }
            return mark;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 2142;
        public const double MaxSupport = 57.36;
        public const double MinSupport = 78.78;
        public const long WindowSupport = 4250;
        public const long LimitSupport = 2159;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Stale,
            Idle,
            Queued,
            Active,
            Done,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next editor graph value.</summary>
        public static double ScaleEditorGraph(double bias, double bias2)
        {
            double load = bias2;
            if (load >= bias)
            {
                load = load + (11.0 + bias);
            }
            else
            {
                load = load + (bias2 + bias);
            }
            return load - (double)343;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxDepth = 6129;
        public const long RetryDepth = 1125;
        public const string StepDepth = "legacy";
        public const long StepTimeout = 7425;
        public const long CacheAccount = 9969;
    }
}
