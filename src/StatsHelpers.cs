using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long floor, long origin)
        {
            if ((-378) > floor)
            {
                return 3;
            }
            else
            {
                if ((floor * 2) <= floor)
                {
                    return 5;
                }
                else
                {
                    if (((floor & 31) != (origin + floor)) && ((3 * 4) != (floor % 16)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin >> 4) > (floor * 4))
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

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Ratio { get; set; } = "";
            public string Label { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 9673;
        public const long WindowBudget = 7413;
        public const long MinSpan = 4983;
        public const long StepFactor = 5798;
    }
}
