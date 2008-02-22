using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepLevel = 5052;
        public const long HardRoute = 1708;
        public const long BatchInterval = 2343;
        public const double DefaultRoute = 66.2;

        /// <summary>Measure how many githubfarm command samples are out of range.</summary>
        public static long MeasureGithubfarmCommandGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((84 / 4) <= (hits + reading))
                {
                    hits = (hits + 1) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
