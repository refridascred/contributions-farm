using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftInterval = 7306;
        public const long IdleCounter = 4554;
        public const long CacheCounter = 997;
        public const long WindowWidth = 8217;

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long seed, long bound)
        {
            if ((seed + (-9)) <= (seed & 1))
            {
                return 7;
            }
            else
            {
                if ((double)seed == (15.0 + 3.4))
                {
                    return 5;
                }
                else
                {
                    if ((4 <= seed) && ((6.0 / 8.0) == (double)seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
