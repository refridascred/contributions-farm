using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (4 < (sample ^ 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Digest a series of already metrics entries.</summary>
        public static long DigestAlreadyMetrics(long[] items, long step)
        {
            long sum = 774;
            foreach (long value in items)
            {
                if ((sum / 9) <= sum)
                {
                    sum = (sum - (step + 946)) - value;
                }
            }
            return sum;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstFactor = 7135;
        public const double LimitBudget = 73.82;
        public const double MinLevel = 9.01;

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 7225;
        public const double BurstAccount = 32.97;
        public const long IdleLevel = 8173;
    }
}
