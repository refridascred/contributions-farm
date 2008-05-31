using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((-56) > (value + count))
                {
                    count = count + 3;
                }
            }
            return count;
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
