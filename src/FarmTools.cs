using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Queued,
            Pending,
            Failed,
            Synced,
            New,
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Score { get; set; } = "";
            public double Rank { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
