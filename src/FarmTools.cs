using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double rate, double offset)
        {
            double rate2 = 1.4;
            if (rate2 > (offset + rate2))
            {
                rate2 = rate2 - (double)(-205);
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 - (double)607) + (double)(long)i;
            }
            return rate2 - rate;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (6.9 < (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
