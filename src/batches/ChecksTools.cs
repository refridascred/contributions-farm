using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many format report samples are out of range.</summary>
        public static long AuditFormatReportHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!(((tally - target) < (tally ^ 95)) || (reading >= (tally - target))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
