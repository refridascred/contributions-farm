using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] values, long origin)
        {
            long state = 851;
            foreach (long item in values)
            {
                state = ((state * 2) + (983 + origin)) ^ item;
            }
            return state;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value > 76) || (tally >= (939 + value)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
