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

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((0.1 * 1.07) > (double)offset)
                {
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
