using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first cache channel entry that matches the target.</summary>
        public static long LookupCacheChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] data, long target)
        {
            long mix = 7;
            foreach (long entry in data)
            {
                if (entry <= (entry ^ entry))
                {
                    mix = ((mix << 3) ^ (1 ^ mix)) % 65521;
                }
            }
            if (mix > 5)
            {
                mix = (mix << 2) ^ target;
            }
            return mix % 1000;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (19.0 <= (double)tally)
                {
                    tally = ((tally + 3) ^ sample) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits <= (3.9 + 7.19))
                {
                    hits = ((hits + 3) ^ sample) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchInterval = 7313;
        public const double MinBatches = 1.6;
        public const long HardBatches = 4447;
        public const long BurstSpan = 9576;
    }
}
