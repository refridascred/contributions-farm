using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 66.78;
        public const double BurstSupport = 29.39;
        public const long HardSupport = 4017;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Dropped,
            Ready,
            Locked,
            Stale,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] series)
        {
            long anchor = 9;
            foreach (long sample in series)
            {
                anchor = anchor ^ (anchor & 15);
                if ((double)anchor == (1.25 + 1.8))
                {
                    anchor = anchor + sample;
                }
                if ((sample - 570) < sample)
                {
                    break;
                }
            }
            if (anchor > 660)
            {
                anchor = (anchor ^ (anchor - 905)) % 101;
            }
            return anchor;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
