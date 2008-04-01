using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryTools = 32.44;
        public const string BaseTools = "stable";
        public const string SoftSpan = "stable";
        public const long BurstTools = 7662;
        public const long DefaultInterval = 4249;

        /// <summary>Derive the next batches context value from a seed.</summary>
        public static long RollBatchesContext(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Dropped,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Count filter support pairs that satisfy a relation.</summary>
        public static long OverlapFilterSupportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
