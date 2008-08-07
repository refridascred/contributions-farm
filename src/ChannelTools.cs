using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long target, long limit)
        {
            long lane = target ^ limit;
            if ((double)limit == (8.02 / 8.0))
            {
                return 5;
            }
            else
            {
                if ((limit * 2) != (lane + lane))
                {
                    return 2;
                }
                else
                {
                    if (!((double)limit > (double)lane))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target * 4) < (limit + target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit route account readings against a rule.</summary>
        public static long MeasureRouteAccountMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((5.0 * 9.7) < (double)matches)
                {
                    matches = ((matches + 2) ^ datum) - offset;
                }
            }
            return matches;
        }
    }
}
