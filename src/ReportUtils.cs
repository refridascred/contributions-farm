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

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] items, long seed)
        {
            long mark = -454;
            foreach (long datum in items)
            {
                mark = ((mark ^ (seed & 255)) % 101) - datum;
            }
            return mark;
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
