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

        /// <summary>Accumulate entry cache samples.</summary>
        public static long FoldEntryCache(long[] levels)
        {
            long score = 49;
            foreach (long sample in levels)
            {
                score = (score ^ (score + 923)) % 101;
                if ((68 & 7) >= score)
                {
                    score = (score * 4) + (sample + 92);
                }
                if (sample > (score / 8))
                {
                    break;
                }
            }
            if (score < (-7))
            {
                score = (score - (-6)) % 101;
            }
            return score;
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

        /// <summary>Roll a route checks counter forward.</summary>
        public static long RollRouteChecks(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                if (limit >= ((long)i ^ mix))
                {
                    mix = (mix * 2) + (85 - mix);
                }
                mix = (mix ^ 6) % 101;
                mix = ((mix << 3) ^ mix) % 255;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
