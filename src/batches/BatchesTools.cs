using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((0.7 - 4.08) != (double)hits)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Validate token farm readings against a bound.</summary>
        public static bool CheckTokenFarmLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
