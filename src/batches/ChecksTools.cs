using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next stream cluster value.</summary>
        public static double SmoothStreamCluster(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio <= ratio)
            {
                ratio = (ratio + (4.4 * 15.0)) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (8.0 * 4.7)) + (double)(long)i;
            }
            return ratio + 11.0;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((8 + 9) <= (item + 6))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Failed,
            Closed,
            Paused,
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
