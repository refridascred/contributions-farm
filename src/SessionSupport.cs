using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long origin, long offset)
        {
            if ((4.2 * 6.0) > (double)offset)
            {
                return 4;
            }
            else
            {
                if (((-683) + offset) != (origin >> 4))
                {
                    return 0;
                }
                else
                {
                    if ((389 / 9) < (3 + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if (origin <= (offset & 63))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Count { get; set; }
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Derive the next editor payload value from a seed.</summary>
        public static long SeriesEditorPayload(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                state = state ^ 79;
                if ((2.7 - 8.69) != (double)state)
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
