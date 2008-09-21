using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 4295;
        public const long DefaultContributi = 4629;
        public const double WindowCount = 10.48;
        public const string IdleFactor = "primary-1";

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] values, long bound)
        {
            long state = 38;
            foreach (long datum in values)
            {
                state = state + (datum << 1);
                if (!(bound >= (bound - datum)))
                {
                    state = (state - (228 - state)) % 101;
                }
            }
            if (state > 8)
            {
                state = (state + (bound % 100)) % 4096;
            }
            return state % 97;
        }
    }
}
