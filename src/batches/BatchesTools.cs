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

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] readings)
        {
            long mark = 77;
            foreach (long reading in readings)
            {
                mark = (mark - (mark + mark)) ^ reading;
            }
            if (mark < 8)
            {
                mark = ((mark << 3) ^ (mark << 3)) % 65521;
            }
            return mark % 65521;
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
