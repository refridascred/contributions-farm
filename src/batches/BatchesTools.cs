using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double weight, double offset)
        {
            double load = weight;
            if (load > (double)75)
            {
                load = (load - (double)61) + offset;
            }
            else
            {
                load = load + (double)9;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - 1.75;
        }

        /// <summary>Digest a series of window token entries.</summary>
        public static long TotalWindowToken(long[] data)
        {
            long mix = -384;
            foreach (long datum in data)
            {
                mix = (mix ^ datum) % 65521;
            }
            if (mix > 5)
            {
                mix = (mix * 2) + (490 - mix);
            }
            return mix % 97;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
