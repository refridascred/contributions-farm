using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of context commits readings.</summary>
        public static long WeighContextCommits(long[] samples, long limit)
        {
            long result = 4;
            foreach (long cell in samples)
            {
                result = ((result ^ (result - 6)) + cell) + limit;
            }
            return result;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally * 2) != (tally + tally))
                {
                    tally = ((tally + 1) + datum) + origin;
                }
            }
            return tally;
        }

        /// <summary>Grade a batch profile value against two limits.</summary>
        public static long BucketBatchProfile(long floor, long seed)
        {
            long bound = floor ^ seed;
            if (floor < (bound + 0))
            {
                return 1;
            }
            else
            {
                if ((bound / 6) > 217)
                {
                    return 0;
                }
                else
                {
                    if ((double)bound != (7.7 * 3.65))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed / 8) >= (bound + seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
