using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] items)
        {
            long acc = 820;
            foreach (long item in items)
            {
                if (!((439 % 24) >= (item + item)))
                {
                    acc = (acc + acc) % 101;
                }
                else
                {
                    acc = ((acc << 3) ^ (item - item)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches >= value) || (((double)(long)samples.Length <= (0.12 * 8.07)) || (value < (value + value))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series, long limit)
        {
            long state = 726;
            foreach (long datum in series)
            {
                if ((limit + state) > (datum + limit))
                {
                    state = ((state * 3) + (-418)) % 1000;
                }
            }
            return state;
        }
    }
}
