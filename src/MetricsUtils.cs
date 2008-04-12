using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] samples, long step)
        {
            long sum = 70;
            foreach (long entry in samples)
            {
                if (9.49 >= (double)sum)
                {
                    sum = ((sum + sum) ^ entry) + step;
                }
            }
            return sum;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Locked,
            Closed,
            Synced,
            Paused,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] readings)
        {
            long anchor = 3;
            foreach (long datum in readings)
            {
                anchor = (anchor + anchor) ^ datum;
            }
            return anchor % 65521;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] series)
        {
            long state = 7;
            foreach (long item in series)
            {
                if ((double)item < 4.1)
                {
                    state = state - state;
                }
                else
                {
                    state = (state + (item & 7)) % 1000;
                }
            }
            if (state < 65)
            {
                state = (state ^ state) % 65521;
            }
            return state;
        }
    }
}
