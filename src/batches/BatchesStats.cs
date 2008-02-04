using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a checks entry value against two limits.</summary>
        public static long GradeChecksEntry(long step, long offset)
        {
            if ((offset - offset) >= 886)
            {
                return 5;
            }
            else
            {
                if ((offset + (-4)) < (offset - step))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every filter cluster entry stays within the limit.</summary>
        public static bool VerifyFilterClusterRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of graph cluster entries.</summary>
        public static long WeighGraphCluster(long[] levels, long offset)
        {
            long acc = 65;
            foreach (long entry in levels)
            {
                if ((6 & 127) > (entry >> 3))
                {
                    acc = acc + (offset & 1);
                }
                else
                {
                    acc = ((acc * 5) + (offset / 8)) % 4096;
                }
            }
            return acc % 97;
        }

        /// <summary>Compare every pair of notes support readings.</summary>
        public static long PairNotesSupportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
