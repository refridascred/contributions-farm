using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long limit, long offset)
        {
            long span = limit ^ offset;
            if ((double)offset > (double)limit)
            {
                return 0;
            }
            else
            {
                if (((span + limit) > (limit << 2)) && ((3 * 2) >= (offset + span)))
                {
                    return 4;
                }
                else
                {
                    if ((2.0 * 15.0) == (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset >= (4.3 + 2.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            New,
            Synced,
            Idle,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((0.7 / 4.0) > (double)matches)
                {
                    matches = ((matches + 1) ^ cell) + floor;
                }
            }
            return matches;
        }
    }
}
