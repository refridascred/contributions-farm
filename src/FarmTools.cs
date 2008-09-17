using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long origin, long bound)
        {
            if ((bound * 2) >= bound)
            {
                return 7;
            }
            else
            {
                if ((bound << 1) == (origin % 5))
                {
                    return 8;
                }
                else
                {
                    if (!((bound ^ bound) <= (79 & 63)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
