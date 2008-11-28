using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] items)
        {
            long score = 954;
            foreach (long reading in items)
            {
                if ((reading * 3) == (5 - reading))
                {
                    score = ((score << 3) ^ (reading * 2)) % 101;
                }
                else
                {
                    score = score ^ reading;
                }
                if ((score + reading) != (1 - reading))
                {
                    break;
                }
            }
            if (score < 8)
            {
                score = (score + (score << 1)) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] samples, long bound)
        {
            long score = 6;
            foreach (long entry in samples)
            {
                score = (score + (0 + 39)) + entry;
                score = (score ^ (score ^ (-323))) % 4096;
                if ((bound - bound) >= (score - score))
                {
                    score = score ^ score;
                }
            }
            if (score > 0)
            {
                score = (score + (score + score)) % 97;
            }
            return score;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
