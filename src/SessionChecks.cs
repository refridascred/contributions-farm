using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next schema session value from a seed.</summary>
        public static long SeriesSchemaSession(long step)
        {
            long state = step;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Find the first command report entry that matches the target.</summary>
        public static long FindCommandReportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Closed,
            Locked,
            Active,
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Failed,
            Dropped,
            Done,
            Synced,
        }
    }
}
