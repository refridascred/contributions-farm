using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Locked,
            Stale,
            Failed,
            Active,
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Stale,
            Paused,
            Dropped,
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
