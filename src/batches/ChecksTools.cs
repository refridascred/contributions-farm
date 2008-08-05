using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two contributi already measurements.</summary>
        public static double AdjustContributiAlready(double scale, double bias)
        {
            double weight = 19.0;
            if (weight <= scale)
            {
                weight = (weight - (scale * 14.0)) + bias;
            }
            return weight - weight;
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
