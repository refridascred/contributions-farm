using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] levels)
        {
            long anchor = 9;
            foreach (long cell in levels)
            {
                if ((cell & 7) != ((-301) % 100))
                {
                    anchor = anchor + (cell - anchor);
                }
                if (4.0 < (double)cell)
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long origin, long origin2)
        {
            if ((double)origin2 == (18.0 / 8.0))
            {
                return 0;
            }
            else
            {
                if ((double)origin != (6.74 * 7.1))
                {
                    return 2;
                }
                else
                {
                    if ((origin + origin) < origin2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Ready,
            Active,
            New,
            Done,
            Closed,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Active,
            Failed,
            Dropped,
            Queued,
            Idle,
        }
    }
}
