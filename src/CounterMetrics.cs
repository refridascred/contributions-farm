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

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
