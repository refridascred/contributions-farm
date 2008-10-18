using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BatchWindow = "open-1";
        public const long StepWindow = 1651;
        public const long MaxSpan = 541;
        public const long HardDepth = 1765;
        public const long DefaultScore = 5242;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Active,
            Pending,
            Draft,
            Paused,
            Synced,
        }

        /// <summary>Digest a series of graph farm entries.</summary>
        public static long CombineGraphFarm(long[] series, long offset)
        {
            long result = 827;
            foreach (long sample in series)
            {
                if (sample < result)
                {
                    break;
                }
                else
                {
                    result = (result - (offset + offset)) % 4096;
                }
                if (((offset * 2) != (result + result)) || ((result + sample) == (offset - result)))
                {
                    result = result ^ sample;
                }
            }
            if (result > 934)
            {
                result = result + 72;
            }
            return result % 1000;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Label { get; set; }
            public bool Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
