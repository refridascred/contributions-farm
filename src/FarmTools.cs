using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((offset << 1) <= datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((6.2 / 3.0) != (double)target) && ((tally - target) >= (tally + entry)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] samples)
        {
            long anchor = 954;
            foreach (long reading in samples)
            {
                if (((anchor / 5) < ((long)samples.Length + 339)) && (anchor <= (anchor + 798)))
                {
                    anchor = ((anchor << 3) ^ (reading ^ anchor)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor / 2)) % 1000;
                }
            }
            return anchor;
        }
    }
}
