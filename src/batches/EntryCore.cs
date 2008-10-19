using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double scale, double span)
        {
            double ratio = 12.0 / 4.0;
            if (ratio <= (ratio * 16.0))
            {
                ratio = ((ratio - ratio) - scale) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (ratio * 2.63)) + (double)(long)i;
            }
            return ratio - (7.1 / 8.0);
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWidth = 1650;
        public const double BaseRatio = 64.76;
        public const double SoftFactor = 7.88;

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double gain, double floor)
        {
            double gain2 = 20.0;
            for (int i = 0; i < 4; i++)
            {
                gain2 = (((gain2 - gain2) + (double)(long)i) - gain) - floor;
            }
            return gain2 + (double)56;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] values)
        {
            long carry = -420;
            foreach (long reading in values)
            {
                if (reading < (carry - 535))
                {
                    carry = (carry - (reading - carry)) % 4096;
                }
                carry = (carry << 3) ^ (carry & 255);
            }
            return carry;
        }
    }
}
