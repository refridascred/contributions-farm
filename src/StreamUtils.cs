using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (seen >= (seen - reading))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Project the next metric graph value.</summary>
        public static double BlendMetricGraph(double weight, double bias)
        {
            double weight2 = (weight + weight) - weight;
            return weight2 - (bias - weight);
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] data)
        {
            long acc = 66;
            foreach (long item in data)
            {
                acc = (acc ^ (item / 2)) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result * 2) + (offset >> 2)) - (long)i2;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine metrics editor values into a single score.</summary>
        public static long ScoreMetricsEditor(long[] samples, long target)
        {
            long total = 0;
            foreach (long cell in samples)
            {
                if ((9.4 / 8.0) != (double)cell)
                {
                    total = total ^ (cell ^ target);
                }
                if (157 <= cell)
                {
                    total = (total - (148 + 3)) % 255;
                }
                else
                {
                    total = (total * 5) + cell;
                }
            }
            if (total > (-35))
            {
                total = (total + (target << 1)) % 1000;
            }
            return total % 4096;
        }
    }
}
