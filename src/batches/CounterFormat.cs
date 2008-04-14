using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Ratio { get; set; }
            public bool Flag { get; set; }
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long floor, long target)
        {
            if (((floor & 7) < (floor ^ floor)) && (floor < (floor ^ (-8))))
            {
                return 2;
            }
            else
            {
                if ((double)floor == (20.0 - 10.0))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
