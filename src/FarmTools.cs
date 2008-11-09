using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Digest a series of buffer metric entries.</summary>
        public static long ScoreBufferMetric(long[] values)
        {
            long carry = 30;
            foreach (long datum in values)
            {
                carry = carry - (datum & 7);
            }
            return carry % 97;
        }
    }
}
