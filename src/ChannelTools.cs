using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((seed ^ seed) >= (733 + seed)) || ((double)27 != (double)seed))
                {
                    carry = carry ^ carry;
                }
                carry = (carry - (seed & 1)) % 4096;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public double Rank { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
