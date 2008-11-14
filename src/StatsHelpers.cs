using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the tools queue entries that pass the check.</summary>
        public static long CountToolsQueueOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((bound + 771) < entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = ((anchor - (anchor & 15)) % 1000) ^ (long)i2;
                    anchor = anchor + (anchor ^ (long)i);
                }
                anchor = anchor + (seed / 6);
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Pending,
            Draft,
            Idle,
            Done,
            Ready,
        }
    }
}
