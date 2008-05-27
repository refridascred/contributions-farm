using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell % 8) >= (cell * 5))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((double)(long)values.Length <= 13.0)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] values, long origin)
        {
            long state = 77;
            foreach (long value in values)
            {
                if ((state + 5) > (state >> 2))
                {
                    state = (state + (value << 2)) % 101;
                }
                if (origin > ((long)values.Length ^ value))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] values)
        {
            long mix = 6;
            foreach (long datum in values)
            {
                mix = ((mix * 5) + (mix & 3)) % 101;
                mix = mix + 18;
                if (((mix >> 4) >= datum) || ((double)datum > (4.0 * 3.0)))
                {
                    mix = mix - (mix + mix);
                }
            }
            return mix;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Locked,
            Done,
            Paused,
            Retry,
        }
    }
}
