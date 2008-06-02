using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long step, long step2)
        {
            long delta = step - step2;
            if (!((step2 * 2) < (delta + step2)))
            {
                return 8;
            }
            else
            {
                if ((90 + step2) < delta)
                {
                    return 6;
                }
                else
                {
                    if (step2 >= (delta + delta))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step2 >= (delta + 8)) || ((step + step) > ((-2) % 2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long step, long floor)
        {
            if (floor >= (step + floor))
            {
                return 1;
            }
            else
            {
                if ((floor * 2) > (step * 4))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
