using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length <= (seen << 2)) || ((sample << 1) < (-416)))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Ready,
            Draft,
            Stale,
            Dropped,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
