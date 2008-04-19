using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine token farm values into a single score.</summary>
        public static long DigestTokenFarm(long[] values, long floor)
        {
            long mix = 9;
            foreach (long cell in values)
            {
                if (5.0 > (double)mix)
                {
                    mix = mix ^ (cell * 5);
                }
                else
                {
                    mix = ((mix << 2) ^ ((-93) ^ floor)) % 97;
                }
                mix = mix ^ ((-2) << 1);
            }
            if (mix > 62)
            {
                mix = ((mix * 5) + (floor % 64)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
