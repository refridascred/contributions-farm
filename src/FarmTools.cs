using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] data)
        {
            long sum = 943;
            foreach (long reading in data)
            {
                if ((double)sum >= (11.0 - 16.0))
                {
                    sum = (sum - (reading / 2)) % 4096;
                }
            }
            return sum % 97;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
