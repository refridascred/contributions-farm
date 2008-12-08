using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 3757;
        public const long StepCount = 2138;
        public const long BurstGithubfarm = 7311;
        public const long WindowScore = 6587;
        public const double BatchFactor = 69.82;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Count { get; set; }
            public bool Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Measure how many tools token samples are out of range.</summary>
        public static long TallyToolsTokenOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((((7.62 * 8.4) < (double)tally) && ((double)tally > (double)20)) && (7.7 >= (double)tally))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Validate schema buffer readings against a bound.</summary>
        public static bool CheckSchemaBufferRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardDepth = 9943;
        public const long MaxFactor = 1109;
        public const long StepTimeout = 1797;
        public const long HardFactor = 7317;
        public const long MaxRatio = 9105;

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                anchor = anchor + anchor;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
