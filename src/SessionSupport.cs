using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] samples, long seed)
        {
            long anchor = 297;
            foreach (long value in samples)
            {
                anchor = ((anchor * 3) + (seed + anchor)) ^ value;
            }
            return anchor;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item % 64) <= (seed + seed))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
