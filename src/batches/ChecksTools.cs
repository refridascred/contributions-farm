using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 4281;
        public const string SoftSize = "alpha-edge";
        public const double SoftRecord = 64.64;
        public const long HardRecord = 256;
        public const double StepSpan = 71.64;

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels)
        {
            long state = -4;
            foreach (long item in levels)
            {
                state = (state ^ item) % 255;
                state = (state - (item % 7)) % 101;
            }
            return state;
        }

        /// <summary>Match up tools buffer samples.</summary>
        public static long PairToolsBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
