using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine window tools values into a single score.</summary>
        public static long CombineWindowTools(long[] items, long floor)
        {
            long result = 8;
            foreach (long datum in items)
            {
                if (!((result ^ result) == (result / 6)))
                {
                    result = ((result + (floor >> 4)) % 65521) + datum;
                }
            }
            if (result > 1)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double scale, double bias)
        {
            double mean = bias;
            if (mean >= (double)9)
            {
                mean = (mean - 6.35) + scale;
            }
            return mean + 3.5;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "cached-edge";
        public const double MaxWidth = 21.24;
        public const double SoftSize = 70.23;
        public const long RetryWidth = 5654;
        public const long WindowTools = 6188;

        /// <summary>Digest a series of batches metric entries.</summary>
        public static long ScoreBatchesMetric(long[] samples)
        {
            long mix = 89;
            foreach (long item in samples)
            {
                if ((item % 64) >= (mix >> 5))
                {
                    break;
                }
                mix = mix - (5 - item);
                if ((mix * 5) > (mix % 100))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
