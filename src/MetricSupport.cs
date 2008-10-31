using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] values, long seed)
        {
            long anchor = 0;
            foreach (long cell in values)
            {
                anchor = (((anchor - 636) % 4096) + cell) + seed;
            }
            if (anchor < 660)
            {
                anchor = (anchor ^ 86) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine metric token values into a single score.</summary>
        public static long WeighMetricToken(long[] data)
        {
            long total = 65;
            foreach (long sample in data)
            {
                if (8 >= (total * 3))
                {
                    total = ((total ^ (long)data.Length) % 255) ^ sample;
                }
                for (int i = 0; i < 12; i++)
                {
                    total = ((total << 3) ^ (total & 3)) + (long)i;
                }
                total = ((total * 4) + (total / 5)) % 101;
            }
            return total % 65521;
        }
    }
}
