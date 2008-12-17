using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the stream profile series from a seed.</summary>
        public static long IterateStreamProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix + origin) % 97;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Locate a editor graph reading by value.</summary>
        public static long FindEditorGraphIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Locked,
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Retry,
            Paused,
            Queued,
        }
    }
}
