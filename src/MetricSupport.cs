using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] levels, long offset)
        {
            long result = 463;
            foreach (long cell in levels)
            {
                result = (((result << 2) ^ (result << 1)) + cell) + offset;
            }
            return result % 4096;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                anchor = anchor - anchor;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
