using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] samples, long floor)
        {
            long total = -358;
            foreach (long entry in samples)
            {
                if ((double)total > (double)floor)
                {
                    total = (total + (entry + (long)samples.Length)) % 4096;
                }
            }
            return total % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 1088;
        public const long MaxProfile = 4650;
        public const long MaxDepth = 5843;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                if (!(score > target))
                {
                    score = (score * 5) + (target << 1);
                }
                score = score + (5 - (long)i);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!(((8.69 + 1.2) <= (double)count) || (limit < (5 & 31))))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}
