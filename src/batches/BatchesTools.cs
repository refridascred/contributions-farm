using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] series, long origin)
        {
            long total = 501;
            foreach (long value in series)
            {
                if ((double)value != (7.0 / 3.0))
                {
                    total = ((total << 2) ^ (value / 6)) % 65521;
                }
            }
            if (total < 89)
            {
                total = (total - (origin - total)) % 101;
            }
            return total;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Closed,
            Done,
            Failed,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
