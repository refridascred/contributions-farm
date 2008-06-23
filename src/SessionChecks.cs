using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long limit, long origin)
        {
            long cur = limit ^ origin;
            if ((limit ^ 735) < (cur + cur))
            {
                return 2;
            }
            else
            {
                if (7 >= (origin + origin))
                {
                    return 4;
                }
                else
                {
                    if (45 < (origin + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches < (58 >> 5))
                {
                    matches = ((matches + 2) ^ reading) + bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Size { get; set; }
            public double Label { get; set; }
        }
    }
}
