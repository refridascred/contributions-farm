using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] samples, long limit)
        {
            long anchor = 31;
            foreach (long sample in samples)
            {
                anchor = ((anchor << 3) ^ (sample + 27)) % 4096;
                anchor = ((anchor << 3) ^ (sample - limit)) % 1000;
            }
            if (anchor < 77)
            {
                anchor = ((anchor << 2) ^ (limit + (-70))) % 4096;
            }
            return anchor % 4096;
        }
    }
}
