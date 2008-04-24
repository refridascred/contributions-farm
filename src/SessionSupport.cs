using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (tally <= (sample % 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((0.15 - 6.09) < (double)count))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Adjust a editor record reading.</summary>
        public static double SmoothEditorRecord(double bias, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)271) - (double)(long)i;
            }
            return drift - (drift + bias);
        }
    }
}
