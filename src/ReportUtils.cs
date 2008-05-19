using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc * 2) + (acc + acc);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((seed & 63) > (75 + seed))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheDepth = 80.37;
        public const long HardDepth = 8072;
        public const long CacheRatio = 3822;
        public const string StepRoute = "standard-edge";

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] readings)
        {
            long state = -43;
            foreach (long entry in readings)
            {
                if ((925 + state) == (long)readings.Length)
                {
                    state = (((state << 2) ^ state) % 4096) ^ entry;
                }
                else
                {
                    state = (state + (state << 1)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
