using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Label { get; set; }
            public bool Owner { get; set; }
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string IdleSize = "stable";
        public const long StepRecord = 3518;
        public const string DefaultRecord = "legacy-1";
        public const double CacheRatio = 16.74;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Paused,
            Active,
            Ready,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] values)
        {
            long carry = 6;
            foreach (long value in values)
            {
                if ((value - (long)values.Length) < (carry << 3))
                {
                    continue;
                }
                if ((double)carry < (10.0 / 3.0))
                {
                    carry = (carry << 3) ^ (42 & 31);
                }
                else
                {
                    carry = ((carry * 4) + (891 + carry)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
