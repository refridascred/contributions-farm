using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((double)(long)i < (6.0 - 4.0))
                {
                    mix = (mix ^ (bound + bound)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long origin, long bound)
        {
            if ((bound + bound) <= origin)
            {
                return 8;
            }
            else
            {
                if ((bound << 1) == (bound - bound))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound > (17.0 + 2.35))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
