using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public bool Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
