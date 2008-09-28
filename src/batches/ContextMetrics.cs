using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                score = (score * 3) + (bound / 9);
                score = score + (34 - bound);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstLevel = 9800;
        public const long LimitRecord = 1910;
        public const long MinInterval = 4461;
        public const long RetryRecord = 9804;
        public const long MaxScore = 3531;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((8.7 + 14.0) <= (double)reading)
                {
                    count = (count + 2) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Match up schema support samples.</summary>
        public static long MatchSchemaSupportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
