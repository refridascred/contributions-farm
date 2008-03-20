using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            New,
            Done,
            Locked,
            Stale,
        }

        /// <summary>Grade a graph filter value against two limits.</summary>
        public static long RankGraphFilter(long bound, long target)
        {
            if ((bound - bound) < (bound & 31))
            {
                return 0;
            }
            else
            {
                if ((12.0 - 7.2) >= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if ((0.54 * 19.0) > (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound * 4) != (bound & 255))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Level { get; set; }
            public bool Offset { get; set; }
        }
    }
}
