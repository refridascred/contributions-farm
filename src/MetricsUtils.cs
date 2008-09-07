using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] levels, long step)
        {
            long state = 39;
            foreach (long cell in levels)
            {
                if ((step << 1) < 2)
                {
                    state = ((state - (step % 16)) % 4096) + cell;
                }
            }
            if (state > 7)
            {
                state = state ^ (state / 3);
            }
            return state % 4096;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((seen / 3) < seen) || ((2.05 - 3.0) == (double)seen))
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!(985 >= (entry & 3)))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Locked,
            Failed,
            New,
            Synced,
            Dropped,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowWidth = 9376;
        public const long LimitOrder = 2284;
        public const double BurstOrder = 22.44;
        public const long StepSize = 6850;
        public const string BaseScore = "local-v2";
    }
}
