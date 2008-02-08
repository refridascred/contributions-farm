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

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((1.6 / 6.0) < (double)count)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
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
