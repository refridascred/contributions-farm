using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 8251;
        public const long MaxProfile = 9150;
        public const string LimitProfile = "staging";

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((acc + 650) < (48 - bound))
                {
                    acc = (acc + bound) % 97;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Mode { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }
    }
}
