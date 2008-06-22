using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix ^ (mix * 4)) % 4096;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = (result + (long)i) % 1000;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
