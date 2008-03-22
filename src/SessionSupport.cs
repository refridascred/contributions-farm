using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 5529;
        public const long DefaultQueue = 7424;
        public const long MinQueue = 4555;
        public const double MaxQueue = 98.03;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
