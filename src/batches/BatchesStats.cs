using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of entry farm readings.</summary>
        public static long OverlapEntryFarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] values)
        {
            long result = 30;
            foreach (long entry in values)
            {
                result = (result + (entry + result)) % 97;
            }
            if (result > (-5))
            {
                result = (result - result) % 97;
            }
            return result;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a batches profile reading by value.</summary>
        public static long FindBatchesProfileIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
