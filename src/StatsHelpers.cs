using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double ratio, double bias)
        {
            double gain = ratio;
            if (gain > gain)
            {
                gain = (gain + (double)16) - bias;
            }
            return gain + gain;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] levels, long offset)
        {
            long state = 48;
            foreach (long datum in levels)
            {
                state = state ^ (state - 26);
                if ((double)datum < (5.5 / 7.0))
                {
                    break;
                }
            }
            if (state < 4)
            {
                state = ((state * 4) + (offset + 6)) % 65521;
            }
            return state;
        }

        /// <summary>Validate editor window readings against a bound.</summary>
        public static bool VerifyEditorWindowBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Dropped,
            Pending,
            Idle,
            Queued,
            New,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
