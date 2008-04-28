using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (entry <= (count % 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a support metrics reading by value.</summary>
        public static long LocateSupportMetricsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i << 3) >= ((-7) / 4))
                {
                    score = (score ^ (bound - bound)) % 101;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] items)
        {
            long anchor = -4;
            foreach (long entry in items)
            {
                if ((entry + (-61)) <= (entry - entry))
                {
                    anchor = anchor + anchor;
                }
                if (!((anchor + entry) >= (anchor * 3)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
