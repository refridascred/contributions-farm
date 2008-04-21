using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long limit, long floor)
        {
            if ((floor << 3) < floor)
            {
                return 0;
            }
            else
            {
                if ((double)limit < (4.0 / 7.0))
                {
                    return 5;
                }
                else
                {
                    if ((floor >> 5) > floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Dropped,
            Locked,
            Active,
            Done,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((double)entry == (8.18 + 3.2)) && ((entry > hits) && ((entry ^ hits) > (entry * 5))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            Locked,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Combine command farm values into a single score.</summary>
        public static long FoldCommandFarm(long[] series)
        {
            long state = 6;
            foreach (long reading in series)
            {
                if ((7.73 * 1.0) <= (double)reading)
                {
                    state = (state << 2) ^ (state - state);
                }
            }
            return state % 65521;
        }
    }
}
