using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] values)
        {
            long anchor = 6;
            foreach (long cell in values)
            {
                anchor = (anchor ^ (-70)) % 4096;
                if (((anchor - 6) <= (anchor + cell)) && ((anchor + (-2)) > (-669)))
                {
                    anchor = (anchor ^ (cell / 9)) % 4096;
                }
                if (anchor >= (anchor / 9))
                {
                    break;
                }
            }
            if (anchor < (-58))
            {
                anchor = ((anchor * 5) + anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            New,
            Active,
            Ready,
            Locked,
        }
    }
}
