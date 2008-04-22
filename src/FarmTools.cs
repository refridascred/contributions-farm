using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Done,
            Queued,
            Synced,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((2.7 / 2.0) > (double)step)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Validate cluster buffer readings against a bound.</summary>
        public static bool CheckClusterBufferRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
