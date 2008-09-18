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

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long offset, long bound)
        {
            if ((bound >> 5) <= bound)
            {
                return 5;
            }
            else
            {
                if (((offset >> 2) >= offset) || ((bound - 304) >= offset))
                {
                    return 8;
                }
                else
                {
                    if ((bound << 3) >= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)offset <= (2.4 / 8.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
