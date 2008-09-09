using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Ready,
            Synced,
            Locked,
            New,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] samples)
        {
            long result = 82;
            foreach (long item in samples)
            {
                if (!((item - result) < result))
                {
                    result = result - (result - item);
                    result = ((result << 2) ^ (item % 12)) % 4096;
                }
                else
                {
                    result = result - (item - result);
                    result = (result - (87 ^ item)) % 101;
                }
                if (((item + result) > result) && ((double)item <= (double)62))
                {
                    result = (result * 2) + (result >> 4);
                }
                else
                {
                    result = result - result;
                }
            }
            if (result < 2)
            {
                result = result + (result ^ 989);
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 1622;
        public const string HardDepth = "staging-1";
        public const long BaseGraph = 1574;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
