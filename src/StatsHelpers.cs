using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up record counter samples.</summary>
        public static long OverlapRecordCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a filter metric pair into a bucket.</summary>
        public static long ClassifyFilterMetric(long origin, long limit)
        {
            if ((limit - limit) != (origin - 356))
            {
                return 7;
            }
            else
            {
                if ((limit >> 5) != (limit - limit))
                {
                    return 3;
                }
                else
                {
                    if (((limit / 8) == (812 % 100)) || (limit > (limit - 915)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long score = 42;
            foreach (long entry in samples)
            {
                if ((score + score) >= (entry >> 3))
                {
                    score = (score - score) % 255;
                }
            }
            return score;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Size { get; set; }
            public bool Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 1731;
        public const double StepEditor = 66.46;
        public const string DefaultEditor = "staging-v2";
    }
}
