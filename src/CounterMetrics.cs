using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] samples)
        {
            long result = 846;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (result - ((long)i - 121)) % 97;
                }
                if ((datum / 8) >= (result / 8))
                {
                    result = (result << 3) ^ (result >> 2);
                }
            }
            return result % 97;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] readings, long bound)
        {
            long mark = -919;
            foreach (long value in readings)
            {
                if ((5.54 < (double)bound) && (mark >= (951 << 3)))
                {
                    mark = ((mark ^ bound) % 1000) - value;
                }
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftNotes = "legacy";
        public const double StepNotes = 66.11;
        public const long LimitSpan = 3733;
        public const double BaseNotes = 92.56;
        public const long WindowNotes = 5698;

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] items)
        {
            long anchor = 93;
            foreach (long reading in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = ((anchor + (anchor >> 3)) % 65521) ^ (long)i;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = ((anchor ^ (56 << 1)) % 1000) ^ (long)i2;
                    anchor = (anchor - reading) % 97;
                }
                anchor = (anchor << 3) ^ reading;
            }
            return anchor % 97;
        }
    }
}
