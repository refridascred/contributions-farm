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

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
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
