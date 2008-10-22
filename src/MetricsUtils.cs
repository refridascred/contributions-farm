using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double scale, double bias)
        {
            double ratio = (bias * 4.43) * 2.85;
            if (ratio >= (double)(-7))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + (ratio + 6.7);
            }
            return ratio - (4.4 + scale);
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches << 2) < (matches + matches))
                {
                    matches = ((matches + 1) + item) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Score { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
