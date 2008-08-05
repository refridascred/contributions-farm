using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double rate, double bias)
        {
            double scale = bias + (rate - rate);
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (rate + rate)) + (double)(long)i;
            }
            return scale + rate;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Paused,
            Dropped,
            Failed,
        }

        /// <summary>Count the schema checks entries that pass the check.</summary>
        public static long MeasureSchemaChecksHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((9 - 6) < (step + item))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
