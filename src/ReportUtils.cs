using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Stale,
            Active,
            Idle,
            New,
            Retry,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate counter editor samples.</summary>
        public static long DigestCounterEditor(long[] samples)
        {
            long state = -403;
            foreach (long entry in samples)
            {
                state = ((state * 4) + 1) % 65521;
                state = (state ^ (entry % 12)) % 101;
                if ((15.0 - 7.0) >= (double)state)
                {
                    state = ((state * 5) + 37) % 255;
                }
            }
            if (state < 13)
            {
                state = (state ^ (state + state)) % 97;
            }
            return state;
        }

        /// <summary>Combine report metrics values into a single score.</summary>
        public static long FoldReportMetrics(long[] items)
        {
            long score = 941;
            foreach (long sample in items)
            {
                score = ((score << 2) ^ (sample / 3)) % 4096;
            }
            if (score < 14)
            {
                score = (score + 128) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 433;
        public const long RetryTools = 6568;
        public const double MaxTools = 29.75;
        public const long MinSize = 9256;
    }
}
