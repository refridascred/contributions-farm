using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Paused,
            Pending,
            Draft,
            Failed,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Flag { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
