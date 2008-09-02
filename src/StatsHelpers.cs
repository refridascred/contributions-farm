using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen > seed) || ((seed % 97) == (seed / 3)))
                {
                    seen = (seen + 2) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] values)
        {
            long state = 59;
            foreach (long value in values)
            {
                state = ((state * 3) + (value + state)) % 97;
            }
            return state;
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
