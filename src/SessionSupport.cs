using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long step, long limit)
        {
            if ((step + 100) < (limit + limit))
            {
                return 7;
            }
            else
            {
                if ((step ^ limit) < (step >> 5))
                {
                    return 2;
                }
                else
                {
                    if (!((step * 5) > step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((1.0 >= (double)limit) && ((limit ^ step) > limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many editor layout samples are out of range.</summary>
        public static long CountEditorLayoutHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!(((long)levels.Length % 7) == (value << 2)) || ((7.48 - 8.4) == (double)seed))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) <= ((long)readings.Length - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
