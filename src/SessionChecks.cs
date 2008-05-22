using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate channel contributi samples.</summary>
        public static long CombineChannelContributi(long[] levels)
        {
            long carry = 67;
            foreach (long cell in levels)
            {
                if (((cell - carry) >= (carry / 3)) || ((carry << 2) == (carry & 7)))
                {
                    carry = carry ^ cell;
                }
            }
            return carry;
        }

        /// <summary>Check that every commits counter entry stays within the limit.</summary>
        public static bool VerifyCommitsCounterLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Token { get; set; }
            public double Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
            public double Label { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
