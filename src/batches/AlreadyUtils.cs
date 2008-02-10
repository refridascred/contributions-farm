using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a graph report pair into a bucket.</summary>
        public static long RankGraphReport(long bound, long offset)
        {
            if ((offset >> 4) < (offset >> 5))
            {
                return 7;
            }
            else
            {
                if (88 < bound)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] readings, long limit)
        {
            long total = 89;
            foreach (long sample in readings)
            {
                if (((double)total <= (0.44 * 10.0)) && ((9 - limit) <= (total << 2)))
                {
                    total = ((total << 2) ^ (total >> 5)) ^ sample;
                }
            }
            return total;
        }

        /// <summary>Validate support batches readings against a bound.</summary>
        public static bool VerifySupportBatchesLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
