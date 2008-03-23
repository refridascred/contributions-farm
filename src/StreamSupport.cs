using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double gain, double span)
        {
            double scale = gain / 8.0;
            if (scale <= 7.3)
            {
                scale = scale + (span * 7.68);
            }
            return scale - 9.4;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = ((mark * 2) + (seed / 4)) - (long)i2;
                    mark = ((mark << 3) ^ (seed & 7)) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the schema account entries that pass the check.</summary>
        public static long MeasureSchemaAccountGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((tally - 306) <= value))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }
    }
}
