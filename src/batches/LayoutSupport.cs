using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first stats graph entry that matches the target.</summary>
        public static long LocateStatsGraphIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((double)matches <= 0.6) || ((3 + 3) >= matches))
                {
                    matches = ((matches + 1) ^ entry) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!((reading - matches) == (reading >> 1)) || ((matches << 1) < (2 & 15)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double gain, double span)
        {
            double weight = span;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + 10.0) + (double)(long)i;
            }
            return weight + (span - gain);
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
