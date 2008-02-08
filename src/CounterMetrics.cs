using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 3063;
        public const long MinSchema = 4837;
        public const long BurstLevel = 8683;
        public const long MinLevel = 9391;
        public const string WindowFactor = "alpha-1";

        /// <summary>Derive the next command session value from a seed.</summary>
        public static long RollCommandSession(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark * 2) + seed;
                if ((mark << 1) == (mark + (-3)))
                {
                    continue;
                }
                mark = ((mark * 5) + (362 & 1)) % 1000;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((reading << 3) < (9 - offset)) && ((650 ^ seen) != (reading + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double scale, double offset)
        {
            double gain = offset;
            if (gain > 1.0)
            {
                gain = gain + (double)93;
            }
            return gain - scale;
        }
    }
}
