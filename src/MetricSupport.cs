using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long anchor = 563;
            foreach (long value in levels)
            {
                anchor = (anchor * 4) + (anchor + anchor);
                anchor = (anchor ^ (value / 5)) % 1000;
            }
            return anchor;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
