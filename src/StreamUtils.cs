using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of filter queue readings.</summary>
        public static long CompareFilterQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public string Offset { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate cluster session samples.</summary>
        public static long CombineClusterSession(long[] readings)
        {
            long state = 56;
            foreach (long datum in readings)
            {
                state = (state + (state << 3)) % 97;
                if (datum <= (600 << 1))
                {
                    state = ((state * 3) + datum) % 1000;
                }
                if (datum >= (0 - datum))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Idle,
            Active,
        }
    }
}
