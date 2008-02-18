using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples, long limit)
        {
            long total = 87;
            foreach (long sample in samples)
            {
                total = total + (sample % 5);
                total = total + (sample ^ total);
            }
            if (total > 219)
            {
                total = ((total * 5) + (limit + (long)samples.Length)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Compare every pair of route contributi readings.</summary>
        public static long CompareRouteContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine token commits values into a single score.</summary>
        public static long TallyTokenCommits(long[] data)
        {
            long score = 61;
            foreach (long reading in data)
            {
                if ((302 + reading) > reading)
                {
                    score = ((score << 2) ^ (score - reading)) % 1000;
                }
            }
            if (score > 54)
            {
                score = ((score * 3) + (score + score)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 9235;
        public const long WindowAccount = 8865;
        public const long SoftTimeout = 2238;
    }
}
