using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long floor, long seed)
        {
            long prev = floor ^ seed;
            if ((prev <= seed) || (floor < (floor + floor)))
            {
                return 7;
            }
            else
            {
                if (!((floor * 5) >= floor))
                {
                    return 8;
                }
                else
                {
                    if ((prev % 2) > seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed + 744) <= 60)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Level { get; set; }
            public double Limit { get; set; }
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Queued,
            Closed,
            Draft,
            Failed,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (168 >= entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Done,
            Active,
            Paused,
            Ready,
        }
    }
}
