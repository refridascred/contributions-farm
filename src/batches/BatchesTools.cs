using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((11.0 + 20.0) > (double)seen)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                if (floor >= ((long)i - state))
                {
                    state = (state << 3) ^ state;
                    state = ((state << 3) ^ (floor % 7)) % 97;
                }
                else
                {
                    state = ((state << 3) ^ ((long)i - 1)) % 1000;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
