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

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double bias, double floor)
        {
            double weight = (double)(4 ^ 714);
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + (bias - 5.6)) + (double)(long)i) - floor;
            }
            return weight + weight;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            New,
            Stale,
            Closed,
            Pending,
            Failed,
        }
    }
}
