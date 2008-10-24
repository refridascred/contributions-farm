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

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
