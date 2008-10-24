using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double weight, double span)
        {
            double load = weight / 7.0;
            if (load > (span + load))
            {
                load = load - (span / 9.0);
            }
            else
            {
                load = load - span;
            }
            return load + weight;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] values)
        {
            long mix = 2;
            foreach (long datum in values)
            {
                mix = ((mix << 2) ^ mix) % 1000;
                if ((datum % 100) == (mix - datum))
                {
                    break;
                }
            }
            if (mix < 981)
            {
                mix = (mix + (mix ^ mix)) % 255;
            }
            return mix;
        }
    }
}
