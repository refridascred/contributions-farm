using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double rate, double offset)
        {
            double mean = rate;
            if (mean > 9.69)
            {
                mean = (mean - (double)61) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)(-372)) + (double)(long)i;
            }
            return mean - (rate * 1.0);
        }

        /// <summary>Validate layout schema readings against a bound.</summary>
        public static bool ValidateLayoutSchemaRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the editor layout entries that pass the check.</summary>
        public static long MeasureEditorLayoutGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading - hits) >= (reading >> 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the payload editor series from a seed.</summary>
        public static long RollPayloadEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 4) + (total ^ offset)) % 101;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
