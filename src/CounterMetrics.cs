using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Failed,
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Count the batches channel entries that pass the check.</summary>
        public static long TallyBatchesChannelHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!((entry > tally) && (0.4 < (double)tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!((double)(long)i < (double)mark))
                {
                    mark = ((mark << 3) ^ (offset - (long)i)) % 65521;
                }
                mark = mark ^ (long)i;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
