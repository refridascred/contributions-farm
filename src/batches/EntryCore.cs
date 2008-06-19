using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine window tools values into a single score.</summary>
        public static long CombineWindowTools(long[] items, long floor)
        {
            long result = 8;
            foreach (long datum in items)
            {
                if (!((result ^ result) == (result / 6)))
                {
                    result = ((result + (floor >> 4)) % 65521) + datum;
                }
            }
            if (result > 1)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Synced,
            New,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "cached-edge";
        public const double MaxWidth = 21.24;
        public const double SoftSize = 70.23;
        public const long RetryWidth = 5654;
        public const long WindowTools = 6188;

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
            public double Size { get; set; }
        }
    }
}
