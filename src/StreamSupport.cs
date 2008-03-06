using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double gain, double bias)
        {
            double mean = gain * 9.95;
            if (mean > gain)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (mean / 4.0);
            }
            return mean + (double)831;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((17.0 / 9.0) != (double)tally)
                {
                    tally = ((tally + 3) + entry) - seed;
                }
            }
            return tally;
        }
    }
}
