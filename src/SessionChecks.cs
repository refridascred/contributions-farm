using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MinTimeout = 1824;
        public const long StepTimeout = 1071;
        public const long LimitMetric = 5011;

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double weight, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias + (2.0 / 4.0)) + (double)(long)i) - weight;
            }
            return bias - offset;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] data)
        {
            long acc = 716;
            foreach (long reading in data)
            {
                if (acc > (acc - acc))
                {
                    acc = acc ^ reading;
                }
            }
            if (acc > 2)
            {
                acc = acc ^ (acc ^ acc);
            }
            return acc;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] data)
        {
            long mark = -1;
            foreach (long datum in data)
            {
                if (((mark >> 2) <= (mark & 7)) || ((double)mark == (double)datum))
                {
                    mark = (mark - datum) % 101;
                }
            }
            return mark;
        }
    }
}
