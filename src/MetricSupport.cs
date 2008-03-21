using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Stale,
            Locked,
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix ^ (step - 44)) % 101;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
