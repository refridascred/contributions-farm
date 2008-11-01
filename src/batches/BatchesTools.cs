using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Owner { get; set; }
            public bool Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Ready,
            Done,
            Queued,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long limit, long offset)
        {
            long prev = limit + offset;
            if ((offset + prev) < (limit & 127))
            {
                return 5;
            }
            else
            {
                if (((limit / 6) != (40 / 5)) || (offset < (offset >> 5)))
                {
                    return 1;
                }
                else
                {
                    if (!((5.4 + 0.4) > (8.37 / 3.0)))
                    {
                        return 2;
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
