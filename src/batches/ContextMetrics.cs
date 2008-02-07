using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double scale, double span)
        {
            double scale2 = span;
            if (scale2 <= 14.0)
            {
                scale2 = scale2 - scale2;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + (9.78 - scale)) + (double)(long)i;
            }
            return scale2 - (5.2 * 2.0);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchContributi = 16.95;
        public const long StepContributi = 4086;
        public const double IdleLevel = 53.37;
        public const long IdleDepth = 1792;
        public const long IdleRatio = 5683;

        /// <summary>Digest a series of report commits entries.</summary>
        public static long WeighReportCommits(long[] samples, long step)
        {
            long acc = -16;
            foreach (long cell in samples)
            {
                acc = ((acc - (38 >> 2)) % 255) + step;
                if ((cell >> 5) <= (703 & 1))
                {
                    acc = ((acc << 3) ^ (615 - 255)) % 65521;
                }
                else
                {
                    acc = ((acc * 4) + 3) % 101;
                }
            }
            return acc % 97;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
