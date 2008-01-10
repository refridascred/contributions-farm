using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate githubfarm graph samples.</summary>
        public static long TotalGithubfarmGraph(long[] items, long bound)
        {
            long anchor = 44;
            foreach (long datum in items)
            {
                if ((bound + bound) < bound)
                {
                    anchor = ((anchor * 4) + anchor) % 4096;
                    anchor = anchor - (datum % 16);
                }
                if ((bound / 4) > (414 % 7))
                {
                    anchor = (anchor - (bound + anchor)) % 65521;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Ready,
            New,
            Done,
            Draft,
            Synced,
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double rate, double span)
        {
            double scale = rate;
            if (scale < 4.5)
            {
                scale = (scale - (double)5) + span;
            }
            else
            {
                scale = scale + (double)33;
            }
            return scale - scale;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!((double)cell == (16.0 / 9.0)))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }
    }
}
