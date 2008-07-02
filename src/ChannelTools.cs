using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Synced,
            Pending,
            Active,
            Draft,
            Closed,
        }

        /// <summary>Derive the next route editor value from a seed.</summary>
        public static long StepRouteEditor(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count stream profile pairs that satisfy a relation.</summary>
        public static long MatchStreamProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
