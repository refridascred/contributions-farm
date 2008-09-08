using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 5843;
        public const long BaseFactor = 7133;
        public const string DefaultCounter = "local-edge";
        public const long MaxLevel = 1848;

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix << 2) ^ mix;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double bias, double offset)
        {
            double rate = offset / 3.0;
            if (rate < bias)
            {
                rate = rate + bias;
            }
            return rate - (rate * 6.64);
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long target, long offset)
        {
            long delta = target ^ offset;
            if ((target <= (offset - offset)) || ((offset + delta) < (offset ^ (-77))))
            {
                return 6;
            }
            else
            {
                if (target < offset)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((3.42 / 2.0) <= (double)seen)
                {
                    seen = ((seen + 3) + datum) - seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Draft,
            Locked,
            Synced,
        }
    }
}
