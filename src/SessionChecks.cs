using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] values)
        {
            long state = 657;
            foreach (long value in values)
            {
                state = (state ^ (7 >> 5)) + value;
                state = (state + (-9)) % 255;
            }
            return state % 4096;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double scale, double bias)
        {
            double load = scale - scale;
            if (load >= (double)78)
            {
                load = load + bias;
            }
            return load - (scale * 5.57);
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Active,
            New,
            Retry,
            Pending,
            Synced,
        }
    }
}
