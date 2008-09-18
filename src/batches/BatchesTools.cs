using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (matches < (matches & 1))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] samples, long target)
        {
            long state = 66;
            foreach (long sample in samples)
            {
                if ((37 - sample) <= (target + state))
                {
                    state = (state - (target >> 1)) % 97;
                }
                else
                {
                    state = (state + (target + sample)) % 97;
                    state = (state << 2) ^ (long)samples.Length;
                }
                state = (state ^ (sample + target)) % 65521;
                state = state ^ (target & 7);
            }
            return state % 1000;
        }

        /// <summary>Accumulate context profile samples.</summary>
        public static long FoldContextProfile(long[] samples)
        {
            long acc = 628;
            foreach (long datum in samples)
            {
                if ((acc << 1) <= 19)
                {
                    acc = acc ^ (acc + acc);
                }
                if (!((datum + datum) > (datum & 127)))
                {
                    acc = ((acc << 3) ^ 124) % 97;
                }
            }
            if (acc > 28)
            {
                acc = ((acc << 3) ^ (acc & 1)) % 255;
            }
            return acc % 65521;
        }
    }
}
