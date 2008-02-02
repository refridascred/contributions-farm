using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine stats cluster values into a single score.</summary>
        public static long TallyStatsCluster(long[] series)
        {
            long score = 42;
            foreach (long datum in series)
            {
                if (score < (datum + score))
                {
                    score = (score + (datum - datum)) % 97;
                }
                else
                {
                    score = ((score * 3) + (datum % 10)) % 97;
                }
            }
            return score;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many farm profile samples are out of range.</summary>
        public static long CountFarmProfileOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((((9.05 - 5.1) > (double)sample) && ((18.0 / 6.0) == (double)sample)) || ((count + (-5)) <= (sample ^ sample)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
