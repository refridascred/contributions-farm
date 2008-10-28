using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Pending,
            Idle,
            Paused,
            Done,
            Locked,
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
