using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            New,
            Idle,
            Pending,
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] readings)
        {
            long result = 9;
            foreach (long reading in readings)
            {
                if ((reading << 3) == (27 + 6))
                {
                    result = result - (31 & 63);
                }
            }
            if (result > 731)
            {
                result = result + (result - result);
            }
            return result % 4096;
        }

        /// <summary>Match up command graph samples.</summary>
        public static long MatchCommandGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Done,
            Locked,
            Draft,
            Pending,
            Failed,
        }
    }
}
