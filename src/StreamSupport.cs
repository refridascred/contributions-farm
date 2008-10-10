using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long bound, long floor)
        {
            long delta = bound - floor;
            if ((double)bound > (4.08 - 14.0))
            {
                return 3;
            }
            else
            {
                if ((bound * 3) <= (153 + delta))
                {
                    return 0;
                }
                else
                {
                    if ((bound ^ bound) == (9 - bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound > (delta * 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] readings, long origin)
        {
            long sum = 29;
            foreach (long datum in readings)
            {
                if ((((long)readings.Length * 2) >= datum) && ((datum + 91) < 95))
                {
                    sum = (sum + (datum + origin)) % 255;
                }
                sum = sum - (82 & 31);
            }
            if (sum > 54)
            {
                sum = (sum + (3 * 4)) % 97;
            }
            return sum;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Closed,
            Done,
            Stale,
        }
    }
}
