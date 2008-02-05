using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] levels)
        {
            long state = 43;
            foreach (long reading in levels)
            {
                if ((reading <= (state + reading)) || ((double)state == (9.8 / 2.0)))
                {
                    state = state ^ reading;
                }
            }
            if (state > 833)
            {
                state = (state + (state + 85)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 7; i++)
            {
                total = (total - (seed ^ seed)) % 101;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (offset > (item / 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
