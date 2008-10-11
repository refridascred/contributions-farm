using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double bias, double offset)
        {
            double mean = (bias * 9.31) - (offset / 6.0);
            if (mean <= (mean * 3.42))
            {
                mean = mean - (mean / 7.0);
            }
            else
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + offset) + (double)(long)i;
            }
            return mean - 0.78;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Draft,
            Dropped,
            New,
            Stale,
            Queued,
        }
    }
}
