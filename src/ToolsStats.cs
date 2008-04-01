using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (62 > tally)
                {
                    tally = ((tally + 2) + cell) + origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long limit, long origin)
        {
            if ((origin >= (limit ^ origin)) || ((origin + origin) > (origin - origin)))
            {
                return 2;
            }
            else
            {
                if ((origin ^ limit) >= (limit - limit))
                {
                    return 5;
                }
                else
                {
                    if ((limit / 9) != (limit ^ origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Idle,
            Retry,
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Retry,
            Synced,
            Paused,
            Dropped,
        }
    }
}
