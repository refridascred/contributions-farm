using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Paused,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchScore = 3145;
        public const double LimitOrder = 66.64;
        public const string MaxSpan = "standard-v2";
        public const double MinOrder = 51.26;
        public const long MaxOrder = 3135;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)seen > (2.4 + 4.61))
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Accumulate batches token samples.</summary>
        public static long FoldBatchesToken(long[] items)
        {
            long state = 926;
            foreach (long value in items)
            {
                if ((value < (state & 31)) || ((state ^ 166) != (value << 1)))
                {
                    state = (state + (value - value)) % 101;
                }
                else
                {
                    state = ((state * 5) + state) % 4096;
                }
            }
            if (state < 172)
            {
                state = (state - (state ^ state)) % 97;
            }
            return state;
        }

        /// <summary>Validate window format readings against a bound.</summary>
        public static bool GuardWindowFormatRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultSession = 18.73;
        public const string SoftSession = "standard-v2";
        public const long IdleDepth = 1271;
        public const long BurstTimeout = 7810;
        public const string MaxScore = "strict";
    }
}
