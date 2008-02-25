using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 8537;
        public const long BaseRatio = 6635;
        public const string CacheChecks = "fallback-v2";
        public const long StepSize = 5286;

        /// <summary>Accumulate order graph samples.</summary>
        public static long TotalOrderGraph(long[] samples)
        {
            long result = 605;
            foreach (long item in samples)
            {
                if ((result - 520) >= result)
                {
                    result = result + (result + result);
                }
                else
                {
                    result = result ^ (item + item);
                }
            }
            if (result < 8)
            {
                result = ((result * 3) + (72 - 903)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Owner { get; set; }
            public double Offset { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Total { get; set; } = "";
            public bool Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Roll a session githubfarm counter forward.</summary>
        public static long IterateSessionGithubfarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Count { get; set; }
            public double Ratio { get; set; }
        }
    }
}
