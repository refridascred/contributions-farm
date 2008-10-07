using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine tools schema values into a single score.</summary>
        public static long ScoreToolsSchema(long[] data)
        {
            long score = 2;
            foreach (long datum in data)
            {
                if (((20 * 5) > datum) && ((7.3 * 0.6) < 6.7))
                {
                    score = ((score * 5) + (datum & 255)) % 65521;
                }
                else
                {
                    score = (score + (score + score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double bias, double offset)
        {
            double weight = (16.0 / 3.0) + (7.8 + offset);
            if (weight < offset)
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight - (bias / 8.0);
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Stale,
            Draft,
            Closed,
        }
    }
}
