using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Synced,
            Active,
            Paused,
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Flag { get; set; }
            public double Count { get; set; }
            public string Level { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                mix = mix + mix;
                mix = ((mix * 3) + step) % 255;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
