using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a cluster checks reading by value.</summary>
        public static long SeekClusterChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long step)
        {
            long sum = step;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 4) + 66) % 65521;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] samples)
        {
            long state = -62;
            foreach (long reading in samples)
            {
                state = ((state * 2) + reading) % 65521;
                state = state - state;
                if ((state + reading) >= (state << 3))
                {
                    break;
                }
            }
            return state;
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
