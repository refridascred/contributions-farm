using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 5788;
        public const long BaseDepth = 5979;
        public const string SoftRatio = "open-1";
        public const long LimitWidth = 9976;

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxSpan = 1094;
        public const long MinCommand = 7556;
        public const long BaseSize = 213;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] series, long seed)
        {
            long result = -62;
            foreach (long sample in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = ((((result ^ ((-3) % 100)) % 65521) ^ (long)i) ^ sample) + seed;
                }
                if ((double)result < (1.57 / 7.0))
                {
                    result = (result << 2) ^ (result ^ result);
                }
            }
            return result;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first support order entry that matches the target.</summary>
        public static long LocateSupportOrderIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
