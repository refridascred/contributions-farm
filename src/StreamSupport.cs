using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Paused,
            Locked,
            Dropped,
            Draft,
            Done,
        }
    }
}
