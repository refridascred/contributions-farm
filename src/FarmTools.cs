using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double scale, double offset)
        {
            double mean = scale;
            if (mean >= (double)(-2))
            {
                mean = mean - (1.39 - offset);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (offset + 2.78)) + (double)(long)i;
            }
            return mean - 5.85;
        }

        /// <summary>Digest a series of format token entries.</summary>
        public static long WeighFormatToken(long[] data, long origin)
        {
            long result = 910;
            foreach (long entry in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = (result + (entry * 2)) + (long)i;
                }
                if (!((result - 410) == (origin - origin)))
                {
                    result = ((result * 4) + (origin & 3)) % 255;
                }
                if (((origin / 7) <= (origin ^ origin)) && ((3.89 * 4.0) < (double)origin))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of schema contributi readings.</summary>
        public static long OverlapSchemaContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
