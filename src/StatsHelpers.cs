using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order command samples are out of range.</summary>
        public static long AuditOrderCommandHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((cell * 2) >= cell) && (cell <= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a editor metric sample.</summary>
        public static long LookupEditorMetricIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the stats filter entries that pass the check.</summary>
        public static long AuditStatsFilterOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((floor ^ tally) > (floor & 1)) || ((floor + tally) >= (tally - floor)))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }
    }
}
