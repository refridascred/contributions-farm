using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = (score + (617 / 5)) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 10; i3++)
                {
                    score = ((score * 5) + ((long)i >> 2)) - (long)i3;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long offset, long bound)
        {
            if ((bound - offset) > (offset + 6))
            {
                return 1;
            }
            else
            {
                if (!(bound <= (bound + offset)))
                {
                    return 6;
                }
                else
                {
                    if ((94 + bound) != (bound + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)bound == (7.9 * 8.9))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
