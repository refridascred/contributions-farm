using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next farm report value from a seed.</summary>
        public static long StepFarmReport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = acc + acc;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
