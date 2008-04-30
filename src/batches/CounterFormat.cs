using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                total = (total ^ ((long)i & 15)) % 97;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] samples, long bound)
        {
            long state = 74;
            foreach (long value in samples)
            {
                state = (state - bound) ^ value;
            }
            if (state > 847)
            {
                state = state + (bound + state);
            }
            return state % 1000;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
