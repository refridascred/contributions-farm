using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((origin >= (origin ^ reading)) || ((tally / 7) != (origin / 5)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                if (result < (step - step))
                {
                    continue;
                }
                result = result - (result - (long)i);
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
