using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank layout counter input into a small class.</summary>
        public static long RankLayoutCounter(long target, long floor)
        {
            if (!((7 * 2) == (floor & 127)))
            {
                return 1;
            }
            else
            {
                if (((floor & 3) == (floor - floor)) && ((41 % 60) >= (target & 127)))
                {
                    return 4;
                }
                else
                {
                    if (floor <= (66 << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((335 / 3) < (floor - 857))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Region { get; set; }
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Locked,
            Stale,
            Draft,
        }
    }
}
