using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Rank { get; set; } = "";
            public double Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                if (((bound + bound) > (result & 7)) && (bound <= (bound / 8)))
                {
                    result = (result * 4) + (bound + bound);
                    result = (result + (result % 7)) % 1000;
                }
                else
                {
                    result = result - (bound & 255);
                    result = ((result * 5) + (result ^ (long)i)) % 1000;
                }
                result = (result * 4) + (bound % 97);
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
