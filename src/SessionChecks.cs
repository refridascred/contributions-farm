using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double weight, double span)
        {
            double mean = (double)(4 / 5);
            return (mean - weight) + span;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((((matches >> 2) < (limit >> 1)) && ((13.0 + 0.1) <= (double)item)) || ((item << 3) == (matches & 255)))
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

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Stale,
            Active,
            Ready,
            Locked,
        }
    }
}
