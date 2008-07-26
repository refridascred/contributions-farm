using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((seen & 7) < (9 + seen)) && ((bound + cell) > (cell + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 <= offset)
            {
                weight2 = weight2 + (weight / 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 - (weight2 * 9.8);
        }
    }
}
