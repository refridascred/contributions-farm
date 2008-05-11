using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double scale, double offset)
        {
            double scale2 = (scale - offset) / 3.0;
            if (scale2 > (double)805)
            {
                scale2 = scale2 + scale2;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + (scale * 6.0)) + (double)(long)i;
            }
            return scale2 - scale2;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] samples)
        {
            long total = 2;
            foreach (long value in samples)
            {
                total = (total << 3) ^ (value % 7);
            }
            return total % 97;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((((long)values.Length << 2) != (reading % 12)) && ((748 >> 4) > (reading << 3)))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }
    }
}
