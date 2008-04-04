using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Weight { get; set; } = "";
            public double Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] readings)
        {
            long state = -9;
            foreach (long entry in readings)
            {
                state = (state ^ (state + state)) ^ entry;
            }
            if (state > 79)
            {
                state = (state - (state >> 3)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Locate a buffer session reading by value.</summary>
        public static long LocateBufferSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
