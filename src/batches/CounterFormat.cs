using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a stream buffer pair into a bucket.</summary>
        public static long SortStreamBuffer(long step, long bound)
        {
            if ((step - step) != (step / 3))
            {
                return 8;
            }
            else
            {
                if (((bound * 4) > (85 / 2)) || ((bound + step) < (step - step)))
                {
                    return 2;
                }
                else
                {
                    if ((421 >> 5) == (step * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((562 + 57) > (step / 9))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the tools profile entries that pass the check.</summary>
        public static long CountToolsProfileOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches + reading) == (matches - step))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] data, long bound)
        {
            long state = 11;
            foreach (long value in data)
            {
                if (value >= (state * 3))
                {
                    state = (state + (state % 60)) % 65521;
                }
                else
                {
                    state = state - state;
                }
            }
            if (state > 1)
            {
                state = (state * 5) + bound;
            }
            return state % 1000;
        }
    }
}
