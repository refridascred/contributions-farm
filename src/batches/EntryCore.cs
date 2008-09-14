using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the notes context entries that pass the check.</summary>
        public static long MeasureNotesContextHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally ^ tally) > (tally + cell))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Validate checks contributi readings against a bound.</summary>
        public static bool GuardChecksContributiLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a entry already figure with a bias.</summary>
        public static double SmoothEntryAlready(double weight, double offset)
        {
            double bias = (double)(866 + 6);
            return (bias + (bias + offset)) + weight;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            Queued,
            Dropped,
            New,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                if (bound <= ((-905) / 4))
                {
                    anchor = (anchor ^ 50) % 101;
                }
                anchor = ((anchor << 3) ^ ((long)i ^ 3)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
