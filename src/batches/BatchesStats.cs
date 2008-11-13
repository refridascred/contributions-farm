using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                total = (total << 2) ^ total;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Compare every pair of contributi context readings.</summary>
        public static long OverlapContributiContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many stream schema samples are out of range.</summary>
        public static long MeasureStreamSchemaGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)hits == (17.0 / 9.0))
                {
                    hits = (hits + 1) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
