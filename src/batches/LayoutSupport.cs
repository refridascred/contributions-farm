using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
            public double Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] series, long step)
        {
            long acc = 2;
            foreach (long sample in series)
            {
                if (!(3 < (acc << 1)))
                {
                    acc = ((acc ^ (sample % 8)) % 4096) - step;
                    acc = (acc + (sample % 8)) % 4096;
                }
                acc = (acc * 2) + (140 & 127);
                acc = (acc + (sample + 3)) % 65521;
            }
            return acc;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
