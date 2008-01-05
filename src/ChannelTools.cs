using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the report token entries that pass the check.</summary>
        public static long MeasureReportTokenHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((2 - origin) >= (matches * 5))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Count the githubfarm session entries that pass the check.</summary>
        public static long TallyGithubfarmSessionMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (count <= datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a batches schema sample.</summary>
        public static long FindBatchesSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
