using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double ratio, double floor)
        {
            double rate = floor;
            if (rate < rate)
            {
                rate = rate - (double)715;
            }
            else
            {
                rate = rate - floor;
            }
            return rate - (ratio + floor);
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Done,
            Stale,
            Dropped,
            Pending,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
