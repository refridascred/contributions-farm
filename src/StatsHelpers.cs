using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((seed << 2) >= ((-9) - tally)))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double gain, double offset)
        {
            double scale = (double)570 + (offset * 6.59);
            return (scale - 1.49) + gain;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats layout samples are out of range.</summary>
        public static long TallyStatsLayoutHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((double)seen != (7.1 - 7.2)) && (((long)readings.Length - (-469)) <= (origin & 31)))
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
