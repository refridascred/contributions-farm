using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!(128 <= (matches + reading)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Label { get; set; }
            public double Limit { get; set; }
            public bool Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] data)
        {
            long result = 209;
            foreach (long item in data)
            {
                if (!((item / 4) != ((long)data.Length / 2)))
                {
                    result = (result ^ (item << 1)) % 4096;
                }
                for (int i = 0; i < 10; i++)
                {
                    result = (result ^ (result + item)) ^ (long)i;
                }
                result = result + item;
            }
            if (result < 813)
            {
                result = (result ^ (result + result)) % 97;
            }
            return result % 4096;
        }
    }
}
