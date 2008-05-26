using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Paused,
            Done,
            Closed,
            Idle,
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the profile queue series from a seed.</summary>
        public static long DeriveProfileQueue(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((double)floor < (6.0 / 9.0))
                {
                    anchor = ((anchor << 3) ^ (anchor - floor)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
