using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of queue layout readings.</summary>
        public static long TallyQueueLayout(long[] levels)
        {
            long mark = 5;
            foreach (long sample in levels)
            {
                mark = (mark + mark) - sample;
            }
            if (mark > 452)
            {
                mark = (mark * 4) + (5 & 127);
            }
            return mark;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Closed,
            Synced,
            New,
            Paused,
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Find the first editor token entry that matches the target.</summary>
        public static long SeekEditorTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
