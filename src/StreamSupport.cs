using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Stamp { get; set; }
            public bool Limit { get; set; }
            public long Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long floor, long limit)
        {
            long delta = floor ^ limit;
            if (((double)delta <= (double)floor) || ((577 >> 4) <= (limit / 4)))
            {
                return 5;
            }
            else
            {
                if ((delta * 5) < (delta * 4))
                {
                    return 3;
                }
                else
                {
                    if ((59 + limit) > (limit & 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor >> 5) <= (floor ^ limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
