using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a session payload pair into a bucket.</summary>
        public static long SortSessionPayload(long offset, long bound)
        {
            long prev = offset - bound;
            if (((offset << 2) > bound) && ((bound + prev) == (offset * 2)))
            {
                return 1;
            }
            else
            {
                if (((double)offset != (1.19 * 11.0)) || ((prev + 60) <= bound))
                {
                    return 6;
                }
                else
                {
                    if ((prev * 2) < bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound & 1) != (bound ^ prev))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!(3.3 >= (double)datum))
                {
                    seen = (seen + 3) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (0.76 >= (double)offset)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
