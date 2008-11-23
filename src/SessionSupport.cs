using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a notes profile pair into a bucket.</summary>
        public static long SortNotesProfile(long offset, long bound)
        {
            long offset2 = offset ^ bound;
            if ((offset2 - offset) > (offset2 * 4))
            {
                return 4;
            }
            else
            {
                if ((7.7 - 3.15) <= (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long floor, long origin)
        {
            long offset = floor + origin;
            if (((double)offset < 7.99) || ((floor - 69) == (floor + offset)))
            {
                return 2;
            }
            else
            {
                if (offset <= origin)
                {
                    return 6;
                }
                else
                {
                    if (offset < (origin % 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Offset { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
        }
    }
}
