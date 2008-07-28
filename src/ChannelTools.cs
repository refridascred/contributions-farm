using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Flag { get; set; }
            public bool Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Ready,
            New,
            Draft,
            Retry,
            Closed,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] series, long seed)
        {
            long sum = 75;
            foreach (long entry in series)
            {
                sum = ((sum * 5) + (entry ^ seed)) % 4096;
                if (((seed & 31) > (seed + sum)) || ((sum % 60) > (entry - sum)))
                {
                    sum = (sum - entry) % 65521;
                }
            }
            return sum;
        }
    }
}
