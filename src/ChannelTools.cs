using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Locked,
            Retry,
            Draft,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((entry % 8) >= (759 << 3)))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Rank contributi notes input into a small class.</summary>
        public static long GradeContributiNotes(long bound, long floor)
        {
            long lane = bound + floor;
            if ((bound ^ lane) >= floor)
            {
                return 3;
            }
            else
            {
                if ((double)lane != (double)4)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
