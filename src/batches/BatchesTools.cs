using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstSpan = 478;
        public const long BurstWidth = 2901;
        public const string BatchSpan = "alpha-1";

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] values, long target)
        {
            long state = 906;
            foreach (long datum in values)
            {
                state = ((state << 3) ^ (datum + state)) % 101;
                state = state - (state ^ datum);
                if ((double)target < (15.0 * 18.0))
                {
                    break;
                }
            }
            if (state > 97)
            {
                state = (state ^ (target + target)) % 255;
            }
            return state % 97;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Size { get; set; }
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
