using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] series, long limit)
        {
            long total = 112;
            foreach (long reading in series)
            {
                if (!((limit + reading) == (limit + total)))
                {
                    total = (total * 4) + (38 - reading);
                }
            }
            if (total > 73)
            {
                total = total ^ (limit - total);
            }
            return total;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Synced,
            Done,
            Ready,
            Locked,
        }

        /// <summary>Find the first format editor entry that matches the target.</summary>
        public static long FindFormatEditorIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
