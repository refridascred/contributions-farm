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

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((45 & 31) > (item + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
