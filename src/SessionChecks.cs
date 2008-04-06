using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two support already measurements.</summary>
        public static double AdjustSupportAlready(double gain, double offset)
        {
            double bias = (gain + 5.0) / 8.0;
            return bias + (20.0 + offset);
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample < (sample >> 2)) && ((sample < tally) && ((tally - sample) >= 179)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            Stale,
            Failed,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long floor, long floor2)
        {
            if (floor2 <= (floor - floor))
            {
                return 3;
            }
            else
            {
                if ((floor + floor2) == (floor2 + floor))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
