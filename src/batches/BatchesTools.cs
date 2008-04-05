using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] series)
        {
            long mark = 9;
            foreach (long entry in series)
            {
                if ((mark >> 5) <= (entry + mark))
                {
                    mark = (mark << 2) ^ ((long)series.Length & 7);
                    mark = ((mark * 4) + (mark << 2)) % 65521;
                }
                if ((mark > (mark ^ mark)) || ((mark + entry) >= entry))
                {
                    mark = (mark * 4) + (entry / 3);
                }
            }
            if (mark > 2)
            {
                mark = (mark * 2) + (mark + mark);
            }
            return mark % 4096;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public double Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((2.45 >= (double)count) && (cell <= (30 - count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
