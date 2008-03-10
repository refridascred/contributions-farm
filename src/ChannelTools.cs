using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next editor channel value from a seed.</summary>
        public static long IterateEditorChannel(long step)
        {
            long state = step;
            for (int i = 0; i < 11; i++)
            {
                state = (state + (long)i) % 255;
                state = state ^ (step % 7);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((2.4 + 18.0) == (double)tally)
                {
                    tally = ((tally + 2) - entry) - bound;
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
