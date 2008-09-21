using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Ready,
            Pending,
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Classify a checks channel pair into a bucket.</summary>
        public static long ClassifyChecksChannel(long seed, long seed2)
        {
            if (seed >= (133 - 4))
            {
                return 7;
            }
            else
            {
                if (((seed - 1) < (seed % 10)) || ((seed2 - 85) == (seed >> 3)))
                {
                    return 3;
                }
                else
                {
                    if ((double)319 > (double)seed2)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Retry,
            Active,
            Paused,
        }
    }
}
