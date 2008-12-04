using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (0.6 > (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MinBudget = "legacy-edge";
        public const double WindowSchema = 70.33;
        public const string CacheSchema = "alpha-edge";
        public const long StepSchema = 1637;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((2.31 * 20.0) <= (double)value)
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((5.0 / 2.0) >= (double)matches) || ((matches & 7) > step))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }
    }
}
