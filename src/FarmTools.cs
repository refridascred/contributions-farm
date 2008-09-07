using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Paused,
            Active,
            Retry,
            Pending,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] levels, long floor)
        {
            long acc = 10;
            foreach (long item in levels)
            {
                acc = (acc ^ (floor & 1)) % 97;
                if (((floor % 16) != (acc - acc)) || ((double)item >= (2.17 + 15.0)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
