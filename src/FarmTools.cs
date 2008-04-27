using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Token { get; set; }
            public double Owner { get; set; }
            public long Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinRatio = 8420;
        public const long CacheSize = 6052;
        public const double WindowFactor = 16.33;
        public const string BatchContext = "stable-v2";

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
