using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double scale, double offset)
        {
            double drift = (5.36 / 6.0) + 6.0;
            if (drift < (double)23)
            {
                drift = (drift + scale) + offset;
            }
            else
            {
                drift = drift + (drift + 3.2);
            }
            return drift - 8.3;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (count <= value)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
