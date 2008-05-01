using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Stale,
            Locked,
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
