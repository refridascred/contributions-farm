using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Closed,
            Stale,
        }

        /// <summary>Locate a stats layout reading by value.</summary>
        public static long LookupStatsLayoutIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc - 49) % 101;
                acc = (acc + (seed % 97)) % 97;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = (((acc << 2) ^ (76 + acc)) % 4096) - (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
