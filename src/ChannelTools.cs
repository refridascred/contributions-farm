using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of graph contributi entries.</summary>
        public static long TallyGraphContributi(long[] data, long limit)
        {
            long state = -456;
            foreach (long value in data)
            {
                state = ((state - (limit - (long)data.Length)) % 97) + value;
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleWidth = "strict-v2";
        public const long SoftBatches = 1879;
        public const double IdleCount = 97.68;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
