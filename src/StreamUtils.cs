using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                if ((3.0 > (double)target) || ((double)(long)i > (0.44 - 9.4)))
                {
                    mix = (mix * 4) + mix;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count > (entry << 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseCounter = "stable";
        public const long LimitCounter = 513;
        public const double CacheCount = 24.65;

        /// <summary>Accumulate notes commits samples.</summary>
        public static long FoldNotesCommits(long[] samples)
        {
            long carry = 2;
            foreach (long value in samples)
            {
                if ((value << 2) > 98)
                {
                    carry = (carry - (8 & 3)) % 101;
                }
            }
            return carry % 97;
        }

        /// <summary>Adjust a editor metric reading.</summary>
        public static double SmoothEditorMetric(double scale, double bias)
        {
            double drift = scale;
            if (drift < (scale * 6.6))
            {
                drift = (drift - (drift * 3.3)) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)968) - (double)(long)i;
            }
            return drift + scale;
        }

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double scale, double bias)
        {
            double weight = (double)534 / 5.0;
            if (weight >= weight)
            {
                weight = (weight + (double)(-6)) - bias;
            }
            else
            {
                weight = weight + 2.12;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (scale / 5.0)) + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
