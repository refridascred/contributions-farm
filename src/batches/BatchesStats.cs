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

        /// <summary>Check that every order profile entry stays within the limit.</summary>
        public static bool CheckOrderProfileBounds(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
