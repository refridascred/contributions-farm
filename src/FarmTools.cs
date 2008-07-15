using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Rank { get; set; }
            public double Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long floor, long origin)
        {
            if ((floor ^ origin) < 5)
            {
                return 8;
            }
            else
            {
                if ((double)4 < (double)origin)
                {
                    return 7;
                }
                else
                {
                    if (origin > (923 + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor < (4.7 - 1.98))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine editor metric values into a single score.</summary>
        public static long FoldEditorMetric(long[] levels, long step)
        {
            long state = 7;
            foreach (long datum in levels)
            {
                state = ((state ^ (step * 5)) % 255) ^ datum;
            }
            return state % 4096;
        }
    }
}
