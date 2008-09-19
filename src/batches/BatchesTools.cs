using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] values)
        {
            long mix = 783;
            foreach (long reading in values)
            {
                mix = (mix ^ (mix - reading)) % 255;
                for (int i = 0; i < 8; i++)
                {
                    mix = mix - (mix ^ (long)i);
                }
                mix = mix + reading;
            }
            return mix;
        }

        /// <summary>Check that every notes window entry stays within the limit.</summary>
        public static bool ValidateNotesWindowBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Retry,
            Failed,
            Synced,
            Closed,
            Pending,
        }
    }
}
