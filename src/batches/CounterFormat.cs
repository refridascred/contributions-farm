using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series)
        {
            long mix = 87;
            foreach (long entry in series)
            {
                if (((mix - mix) <= (mix & 255)) || ((entry + mix) != (entry << 1)))
                {
                    mix = ((mix * 5) + (entry + 227)) % 97;
                }
                if ((1.9 + 11.0) >= (double)entry)
                {
                    mix = mix + (mix - mix);
                }
            }
            return mix;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Owner { get; set; }
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Size { get; set; } = "";
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
