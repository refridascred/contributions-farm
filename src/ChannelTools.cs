using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double offset)
        {
            double scale = offset;
            return scale + (ratio - offset);
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally + tally) <= item)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((7 / 9) >= (offset & 31)) && (((double)offset == (5.0 * 8.4)) || ((6 ^ offset) < offset)))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }
    }
}
