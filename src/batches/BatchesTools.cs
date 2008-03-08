using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Pending,
            Done,
            New,
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a command contributi pair into a bucket.</summary>
        public static long ClassifyCommandContributi(long seed, long offset)
        {
            if (seed >= (offset + 5))
            {
                return 6;
            }
            else
            {
                if (((seed / 2) < 4) || ((offset >> 1) >= (5 ^ seed)))
                {
                    return 1;
                }
                else
                {
                    if ((seed <= offset) || ((double)seed < (5.0 / 2.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset * 5) == (offset + seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
